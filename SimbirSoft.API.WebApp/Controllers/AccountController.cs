using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

using Simbirsoft.API.Infrastructure.Interfaces;

using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.Requests.Auth;
using SimbirSoft.API.Models.Responses.User;
using SimbirSoft.API.Services.Interfaces;

namespace SimbirSoft.API.WebApp.Controllers
{
    /// <summary>
    /// Account controller.
    /// </summary>
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUserService _userService;
        private readonly IJwtAuthManager _jwtAuthManager;

        /// <summary>
        /// Initialize object of <see cref="AccountController"/>
        /// </summary>
        /// <param name="logger">Logger.</param>
        /// <param name="userService">Service.</param>
        /// <param name="jwtAuthManager">Auth manager.</param>
        public AccountController(ILogger<AccountController> logger, IUserService userService, IJwtAuthManager jwtAuthManager)
        {
            _logger = logger;
            _userService = userService;
            _jwtAuthManager = jwtAuthManager;
        }

        /// <summary>
        /// LogIn endpoint.
        /// </summary>
        /// <param name="request">LogIn request <see cref="LoginRequest"/></param>
        /// <returns><see cref="ActionResult"/></returns>
        [AllowAnonymous]
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!_userService.IsValidUserCredentials(request.Login, request.Password))
            {
                return Unauthorized();
            }

            var role = _userService.GetUserRole(request.Login);
            // add claims to token
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, request.Login),
                new Claim(ClaimTypes.Role, role)
            };
            // jwt generate
            var jwtResult = _jwtAuthManager.GenerateTokens(request.Login, claims, DateTime.Now);
            _logger.LogInformation($"User [{request.Login}] logged in the system.");
            return Ok(new LoginResponse
            {
                Login = request.Login,
                Role = role,
                AccessToken = jwtResult.AccessToken,
                RefreshToken = jwtResult.RefreshToken.TokenString
            });
        }

        /// <summary>
        /// Get current user enpoint
        /// </summary>
        /// <returns><see cref="LoginResponse"/></returns>
        [HttpGet("user")]
        [Authorize]
        public ActionResult GetCurrentUser()
        {
            return Ok(new LoginResponse
            {
                Login = User.Identity.Name,
                Role = User.FindFirst(ClaimTypes.Role)?.Value ?? Models.UserRoles.Default
            });
        }

        /// <summary>
        /// Logout endpoint.
        /// </summary>
        [HttpPost("logout")]
        [Authorize]
        public ActionResult Logout()
        {
            var userName = User.Identity.Name;
            _jwtAuthManager.RemoveRefreshTokenByUserName(userName);
            _logger.LogInformation($"User [{userName}] logged out the system.");
            return Ok();
        }

        /// <summary>
        /// Endpoint for refresh.
        /// </summary>
        /// <param name="request"><see cref="RefreshTokenRequest"/></param>
        /// <returns><see cref="LoginResponse"/></returns>
        [HttpPost("refresh-token")]
        [Authorize]
        public async Task<ActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            try
            {
                var userName = User.Identity.Name;
                _logger.LogInformation($"User [{userName}] is trying to refresh JWT token.");

                if (string.IsNullOrWhiteSpace(request.RefreshToken))
                {
                    return Unauthorized();
                }

                var accessToken = await HttpContext.GetTokenAsync("Bearer", "access_token");
                var jwtResult = _jwtAuthManager.Refresh(request.RefreshToken, accessToken, DateTime.Now);
                _logger.LogInformation($"User [{userName}] has refreshed JWT token.");
                return Ok(new LoginResponse
                {
                    Login = userName,
                    Role = User.FindFirst(ClaimTypes.Role)?.Value ?? string.Empty,
                    AccessToken = jwtResult.AccessToken,
                    RefreshToken = jwtResult.RefreshToken.TokenString
                });
            }
            catch (SecurityTokenException e)
            {
                return Unauthorized(e.Message); // 401
            }
        }

        // next 2 endpoints immitates Impersonation attack.
        // admin can impersonate a user with a different role
        // you don't need it in you homework, just for example!!!
        // see https://www.sciencedirect.com/topics/computer-science/authentication-attack

        [HttpPost("impersonation")]
        [Authorize(Roles = Models.UserRoles.Admin)]
        public ActionResult Impersonate([FromBody] ImpersonationRequest request)
        {
            var userName = User.Identity.Name;
            _logger.LogInformation($"User [{userName}] is trying to impersonate [{request.Login}].");

            var impersonatedRole = _userService.GetUserRole(request.Login);
            if (string.IsNullOrWhiteSpace(impersonatedRole))
            {
                _logger.LogInformation($"User [{userName}] failed to impersonate [{request.Login}] due to the target user not found.");
                return BadRequest($"The target user [{request.Login}] is not found.");
            }
            if (impersonatedRole == API.Models.UserRoles.Admin)
            {
                _logger.LogInformation($"User [{userName}] is not allowed to impersonate another Admin.");
                return BadRequest("This action is not supported.");
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name,request.Login),
                new Claim(ClaimTypes.Role, impersonatedRole),
            };

            var jwtResult = _jwtAuthManager.GenerateTokens(request.Login, claims, DateTime.Now);
            _logger.LogInformation($"User [{request.Login}] is impersonating [{request.Login}] in the system.");
            return Ok(new LoginResponse
            {
                Login = request.Login,
                Role = impersonatedRole,
                AccessToken = jwtResult.AccessToken,
                RefreshToken = jwtResult.RefreshToken.TokenString
            });
        }

        [HttpPost("stop-impersonation")]
        public ActionResult StopImpersonation()
        {
            var userName = User.Identity.Name;

            if (string.IsNullOrWhiteSpace(userName))
            {
                return BadRequest("You are not impersonating anyone.");
            }
            _logger.LogInformation($"User [{userName}] is trying to stop impersonate [{userName}].");

            var role = _userService.GetUserRole(userName);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,userName),
                new Claim(ClaimTypes.Role, role)
            };

            var jwtResult = _jwtAuthManager.GenerateTokens(userName, claims, DateTime.Now);
            _logger.LogInformation($"User [{userName}] has stopped impersonation.");
            return Ok(new LoginResponse
            {
                Login = userName,
                Role = role,
                AccessToken = jwtResult.AccessToken,
                RefreshToken = jwtResult.RefreshToken.TokenString
            });
        }
    }
}
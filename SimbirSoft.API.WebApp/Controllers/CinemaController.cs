using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;
using SimbirSoft.API.WebApp.Common.Swagger;

namespace SimbirSoft.API.WebApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerGroups.Cinema)]
	public class CinemaController : ControllerBase
	{
		private readonly ILogger<CinemaController> _logger;
		private readonly ICinemaService _cinemaService;

		public CinemaController(ICinemaService cinemaService, ILogger<CinemaController> logger)
		{
			_logger = logger;
			_cinemaService = cinemaService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CinemaDTO>))]
		public IActionResult Get()
		{
			var response = _cinemaService.GetCinemas();

			return Ok(response);
		}
	}
}

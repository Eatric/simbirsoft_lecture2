using System;
using System.Text;


using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using Simbirsoft.API.Infrastructure.Interfaces;
using Simbirsoft.API.Infrastructure.Services;

namespace Simbirsoft.API.Infrastructure.Bootstrap
{
	/// <summary>
	/// Расширение для конфигурации аутентификации
	/// </summary>
	public static class InfrastructureConfiguration
	{
		/// <summary>
		/// Метод конфигурации аутентификации
		/// </summary>
		/// <param name="services">Список сервисов</param>
		public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
		{
            var jwtTokenConfig = configuration.GetSection("jwtTokenConfig").Get<JwtTokenConfig>();
            services.AddSingleton(jwtTokenConfig);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                // the authentication requires HTTPS for the metadata address or authority
                x.RequireHttpsMetadata = true;
                // saves the JWT access token in the current HttpContext,
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtTokenConfig.Issuer,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtTokenConfig.Secret)),
                    ValidAudience = jwtTokenConfig.Audience,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(1)
                };
            });
            services.AddSingleton<IJwtAuthManager, JwtAuthManager>();
			services.AddHostedService<JwtRefreshTokenCache>();
		}
	}
}

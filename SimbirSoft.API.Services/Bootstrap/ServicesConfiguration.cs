using Microsoft.Extensions.DependencyInjection;

using SimbirSoft.API.Services.Entities;
using SimbirSoft.API.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Services.Bootstrap
{
	/// <summary>
	/// Методы для конфигурации сервисов
	/// </summary>
	public static class ServicesConfiguration
	{
		/// <summary>
		/// Конфигурация сервисов
		/// </summary>
		/// <param name="services">Сервисы из Startup</param>
		public static void ConfigureServices(this IServiceCollection services)
		{
			services.AddScoped<ICinemaService, CinemaService>();
		}
	}
}

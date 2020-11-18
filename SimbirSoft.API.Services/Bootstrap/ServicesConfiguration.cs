using Microsoft.Extensions.DependencyInjection;

using SimbirSoft.API.Services.Entities;
using SimbirSoft.API.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Services.Bootstrap
{
	public static class ServicesConfiguration
	{
		public static void ConfigureServices(this IServiceCollection services)
		{
			services.AddScoped<ICinemaService, CinemaService>();
		}
	}
}

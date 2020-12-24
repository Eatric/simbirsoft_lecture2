using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimbirSoft.API.Services.Bootstrap;
using SimbirSoft.API.WebApp.Common.Swagger;
using System.Reflection;
using AutoMapper;
using SimbirSoft.API.Database.Bootstrap;
using Simbirsoft.API.Repositories.Bootstrap;
using SimbirSoft.API.Models.Requests.Cinema;
using SimbirSoft.API.Services.Entities;
using Simbirsoft.API.Infrastructure.Bootstrap;

namespace SimbirSoft.API.WebApp
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors();
			services.ConfigureAuthentication(Configuration);
			services.ConfigureDb(Configuration);
			services.ConfigureRepositories();
			services.AddControllers();
			services.ConfigureServices();
			services.AddAutoMapper(
				typeof(CreateCinemaRequest).GetTypeInfo().Assembly,
				typeof(CinemaService).GetTypeInfo().Assembly
			);
			services.ConfigureSwagger();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("./swagger/v1/swagger.json", "JWT Auth Demo V1");
				c.DocumentTitle = "JWT Auth Demo";
				c.RoutePrefix = string.Empty;
			});

			app.UseRouting();

			app.UseCors(x => x.WithOrigins("http://localhost:5000", "https://localhost:5001"));
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});


			logger.LogInformation("End configure");
		}
	}
}

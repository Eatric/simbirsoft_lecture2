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
using SimbirSoft.API.Database.Domain;

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
			services.ConfigureDb(Configuration);
			services.AddControllers();
			services.ConfigureServices();
			services.AddAutoMapper(typeof(Cinema).GetTypeInfo().Assembly);
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

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			app.UseCors();
			app.UseOpenApi();
			app.UseSwaggerUi3();

			logger.LogInformation("End configure");
		}
	}
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace SimbirSoft.API.Database.Contexts
{
	/// <summary>
	/// Фабрика создания контекста для подключения к БД
	/// </summary>
	internal sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CinemaContext>
	{
		/// <summary>
		/// Метод для создания контекста с подключением к БД
		/// </summary>
		/// <param name="args">Аргументы переданные при вызове</param>
		/// <returns><see cref="CinemaContext"/></returns>
		public CinemaContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", false, true)
				.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, true)
				.AddEnvironmentVariables()
				.Build();

			var connectionString = configuration.GetConnectionString(nameof(CinemaContext));

			var builder = new DbContextOptionsBuilder<CinemaContext>()
				.UseNpgsql(connectionString, options =>
				{
					options.MigrationsAssembly(typeof(CinemaContext).Assembly.FullName);
				});

			var context = new CinemaContext(builder.Options);

			return context;
		}
	}
}

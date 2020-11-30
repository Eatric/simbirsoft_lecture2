using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SimbirSoft.API.Database.Contexts;

namespace SimbirSoft.API.Database.Bootstrap
{
	/// <summary>
	/// Конфигурация БД
	/// </summary>
	public static class DbConfiguration
	{
		/// <summary>
		/// Конфигурация контекста базы данных Кинотеатров
		/// </summary>
		/// <param name="services">Список сервисов</param>
		/// <param name="configuration">Конфигурация</param>
		public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<CinemaContext>(
				options => options.UseNpgsql(
					configuration.GetConnectionString(nameof(CinemaContext)),
					builder => builder.MigrationsAssembly(typeof(CinemaContext).Assembly.FullName))
				);
		}
	}
}

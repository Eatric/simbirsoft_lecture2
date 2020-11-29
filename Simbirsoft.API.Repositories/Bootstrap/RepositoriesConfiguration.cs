using Microsoft.Extensions.DependencyInjection;
using Simbirsoft.API.Repositories.Interfaces;

namespace Simbirsoft.API.Repositories.Bootstrap
{
	/// <summary>
	/// Расширение для конфигурации репозиториев
	/// </summary>
	public static class RepositoriesConfiguration
	{
		/// <summary>
		/// Метод конфигурации репозиториев
		/// </summary>
		/// <param name="services">Список сервисов</param>
		public static void ConfigureRepositories(this IServiceCollection services)
		{
			services.AddScoped<ICinemaRepository, CinemaRepository>();
			services.AddScoped<IMovieRepository, MovieRepository>();
		}
	}
}

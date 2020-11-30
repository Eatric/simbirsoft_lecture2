using AutoMapper;
using Simbirsoft.API.Repositories.Interfaces;
using SimbirSoft.API.Database.Contexts;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace Simbirsoft.API.Repositories
{
	/// <summary>
	/// Репозиторий для работы с <see cref="Movie"/>
	/// </summary>
	public class MovieRepository : BaseRepository<MovieDTO, Movie>, IMovieRepository
	{
		/// <summary>
		/// Инициализирует экземпляр <see cref="MovieRepository"/>
		/// </summary>
		/// <param name="context">Контекст данных</param>
		/// <param name="mapper">Маппер сущностей</param>
		public MovieRepository(CinemaContext context, IMapper mapper) : base(context, mapper) { }
	}
}

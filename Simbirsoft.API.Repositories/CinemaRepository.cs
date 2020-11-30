using AutoMapper;
using Simbirsoft.API.Repositories.Interfaces;
using SimbirSoft.API.Database.Contexts;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace Simbirsoft.API.Repositories
{
	/// <summary>
	/// Репозиторий для работы с <see cref="Cinema"/>
	/// </summary>
	public class CinemaRepository : BaseRepository<CinemaDTO, Cinema>, ICinemaRepository
	{
		/// <summary>
		/// Инициализация экземпляр <see cref="CinemaRepository"/>
		/// </summary>
		/// <param name="context">Контекст данных</param>
		/// <param name="mapper">Маппер сущностей</param>
		public CinemaRepository(CinemaContext context, IMapper mapper) : base(context, mapper) { }
	}
}

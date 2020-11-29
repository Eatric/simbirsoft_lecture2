using AutoMapper;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping для <see cref="Movie"/>
	/// </summary>
	public class MovieProfile : Profile
	{
		/// <summary>
		/// Метод инициализации маппинга между <see cref="Movie"/> и <see cref="MovieDTO"/>
		/// </summary>
		public MovieProfile()
		{
			CreateMap<Movie, MovieDTO>();
		}
	}
}

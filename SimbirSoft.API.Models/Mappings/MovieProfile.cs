using AutoMapper;

using SimbirSoft.API.Models.Domain;
using SimbirSoft.API.Models.DTO;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping для <see cref="Movie"/>
	/// </summary>
	public class MovieProfile : Profile
	{
		public MovieProfile()
		{
			CreateMap<Movie, MovieDTO>();
		}
	}
}

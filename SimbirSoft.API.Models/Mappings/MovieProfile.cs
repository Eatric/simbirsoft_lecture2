using AutoMapper;

using SimbirSoft.API.Models.Domain;
using SimbirSoft.API.Models.DTO;

namespace SimbirSoft.API.Models.Mappings
{
	public class MovieProfile : Profile
	{
		public MovieProfile()
		{
			CreateMap<Movie, MovieDTO>();
		}
	}
}

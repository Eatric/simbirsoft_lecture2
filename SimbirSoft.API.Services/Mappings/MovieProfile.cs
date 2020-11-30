using AutoMapper;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Models.Requests.Movie;
using SimbirSoft.API.Models.Responses.Movie;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping запросов/ответов для <see cref="Movie"/>
	/// </summary>
	public class MovieProfile : Profile
	{
		/// <summary>
		/// Метод инициализации маппинга запросов/ответов для <see cref="Movie"/>
		/// </summary>
		public MovieProfile()
		{
			CreateMap<CreateMovieRequest, MovieDTO>();
			CreateMap<UpdateMovieRequest, MovieDTO>();
			CreateMap<MovieDTO, MovieResponse>();
		}
	}
}

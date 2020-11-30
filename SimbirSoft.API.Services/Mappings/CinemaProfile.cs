using AutoMapper;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Models.Requests.Cinema;
using SimbirSoft.API.Models.Responses.Cinema;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping запросов/ответов для <see cref="Cinema"/>
	/// </summary>
	public class CinemaProfile : Profile
	{
		/// <summary>
		/// Метод инициализации маппинга запросов/ответов для <see cref="Cinema"/>
		/// </summary>
		public CinemaProfile()
		{
			CreateMap<CreateCinemaRequest, CinemaDTO>();
			CreateMap<UpdateCinemaRequest, CinemaDTO>();
			CreateMap<CinemaDTO, CinemaResponse>();
		}
	}
}

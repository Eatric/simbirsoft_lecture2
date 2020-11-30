using AutoMapper;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Models.Requests.Cinema;
using SimbirSoft.API.Models.Responses.Cinema;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping для <see cref="Cinema"/>
	/// </summary>
	public class CinemaProfile : Profile
	{
		/// <summary>
		/// Метод инициализации маппинга для <see cref="Cinema"/>
		/// </summary>
		public CinemaProfile()
		{
			CreateMap<Cinema, CinemaDTO>().ReverseMap();
			CreateMap<CreateCinemaRequest, CinemaDTO>();
			CreateMap<UpdateCinemaRequest, CinemaDTO>();
			CreateMap<CinemaDTO, CinemaResponse>();
		}
	}
}

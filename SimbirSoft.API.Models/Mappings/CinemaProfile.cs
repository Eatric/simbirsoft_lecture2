using AutoMapper;
using SimbirSoft.API.Models.Domain;
using SimbirSoft.API.Models.DTO;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping для <see cref="Cinema"/>
	/// </summary>
	public class CinemaProfile : Profile
	{
		/// <summary>
		/// Метод инициализации маппинга <see cref="Cinema"/> и <see cref="CinemaDTO"/>
		/// </summary>
		public CinemaProfile()
		{
			CreateMap<Cinema, CinemaDTO>();
		}
	}
}

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
		public CinemaProfile()
		{
			CreateMap<Cinema, CinemaDTO>();
		}
	}
}

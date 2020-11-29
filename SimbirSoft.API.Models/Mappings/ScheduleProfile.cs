using AutoMapper;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping для <see cref="Schedule"/>
	/// </summary>
	public class ScheduleProfile : Profile
	{
		/// <summary>
		/// Инициализация профиля маппинга
		/// </summary>
		public ScheduleProfile()
		{
			CreateMap<Schedule, ScheduleDTO>();
		}
	}
}

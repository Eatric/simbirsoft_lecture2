using AutoMapper;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping для <see cref="Ticket"/>
	/// </summary>
	public class TicketProfile : Profile
	{
		/// <summary>
		/// Инициализация профиля маппинга
		/// </summary>
		public TicketProfile()
		{
			CreateMap<Ticket, TicketDTO>();
		}
	}
}

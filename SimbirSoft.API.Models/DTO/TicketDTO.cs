using SimbirSoft.API.Database.Domain;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="Ticket"/>
	/// </summary>
	public class TicketDTO : BaseDto
	{
		/// <summary>
		/// Расписание
		/// </summary>
		public ScheduleDTO Schedule { get; set; }

		/// <summary>
		/// Стоимость билета
		/// </summary>
		[Required]
		public double Cost { get; set; }

		/// <summary>
		/// Номер места
		/// </summary>
		[Required]
		public int SeatNumber { get; set; }
	}
}

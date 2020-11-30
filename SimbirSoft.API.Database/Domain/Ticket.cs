using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Билет в кино
	/// </summary>
	public class Ticket : BaseEntity
	{
		/// <summary>
		/// Расписание
		/// </summary>
		public Schedule Schedule { get; set; }

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

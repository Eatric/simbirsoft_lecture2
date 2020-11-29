using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Models.Domain
{
	/// <summary>
	/// Билет в кино
	/// </summary>
	public class Ticket
	{
		/// <summary>
		/// Идентификатор билета
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Идентификатор расписания
		/// </summary>
		public long ScheduleId { get; set; }

		/// <summary>
		/// Стоимость билета
		/// </summary>
		public double Cost { get; set; }

		/// <summary>
		/// Номер места
		/// </summary>
		public int SeatNumber { get; set; }
	}
}

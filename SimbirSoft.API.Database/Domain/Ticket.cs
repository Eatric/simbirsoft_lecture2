using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Билет в кино
	/// </summary>
	public class Ticket
	{
		/// <summary>
		/// Идентификатор билета
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

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

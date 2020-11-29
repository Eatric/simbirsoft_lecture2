using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Models.Domain
{
	/// <summary>
	/// Расписание фильмов в кинотеатре
	/// </summary>
	public class Schedule
	{
		/// <summary>
		/// Идентификатор расписания
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Идентификатор кинотеатра
		/// </summary>
		public long IdCinema { get; set; }

		/// <summary>
		/// Идентификатор фильма
		/// </summary>
		public long IdMovie { get; set; }

		/// <summary>
		/// Время начала сеанса
		/// </summary>
		public DateTime TimeStart { get; set; }

		/// <summary>
		/// Время конца сеанса
		/// </summary>
		public DateTime TimeEnd { get; set; }

		/// <summary>
		/// Номер зала в кинотеатре
		/// </summary>
		public long HallNumber { get; set; }
	}
}

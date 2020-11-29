using System;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Расписание фильмов в кинотеатре
	/// </summary>
	public class Schedule : BaseEntity
	{
		/// <summary>
		/// Кинотеатр
		/// </summary>
		public Cinema Cinema { get; set; }

		/// <summary>
		/// Фильм
		/// </summary>
		public Movie Movie { get; set; }

		/// <summary>
		/// Время начала сеанса
		/// </summary>
		[Required]
		public DateTime TimeStart { get; set; }

		/// <summary>
		/// Время конца сеанса
		/// </summary>
		[Required]
		public DateTime TimeEnd { get; set; }

		/// <summary>
		/// Номер зала в кинотеатре
		/// </summary>
		[Required]
		public long HallNumber { get; set; }
	}
}

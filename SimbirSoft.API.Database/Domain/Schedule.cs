using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Расписание фильмов в кинотеатре
	/// </summary>
	public class Schedule
	{
		/// <summary>
		/// Идентификатор расписания
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

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

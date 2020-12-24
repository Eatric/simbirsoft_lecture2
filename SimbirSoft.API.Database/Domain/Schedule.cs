using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Расписание фильмов в кинотеатре
	/// </summary>
	public class Schedule : BaseEntityWithTwoLinks<Cinema, Movie>
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

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

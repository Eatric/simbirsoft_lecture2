using SimbirSoft.API.Database.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="Schedule"/>
	/// </summary>
	public class ScheduleDTO : BaseDto
	{
		/// <summary>
		/// Кинотеатр
		/// </summary>
		public CinemaDTO Cinema { get; set; }

		/// <summary>
		/// Фильм
		/// </summary>
		public MovieDTO Movie { get; set; }

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

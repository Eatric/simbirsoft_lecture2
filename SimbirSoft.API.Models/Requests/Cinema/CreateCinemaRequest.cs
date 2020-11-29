using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimbirSoft.API.Models.Requests.Cinema
{
	/// <summary>
	/// Запрос на создание сущности кинотеатра
	/// </summary>
	public class CreateCinemaRequest
	{
		/// <summary>
		/// Имя кинотеатра
		/// </summary>
		[Required, MaxLength(50)]
		public string Name { get; set; }

		/// <summary>
		/// Адрес кинотеатра
		/// </summary>
		[Required, MaxLength(200)]
		public string Address { get; set; }

		/// <summary>
		/// Количество кинозалов
		/// </summary>
		[Required]
		public byte NumberOfHalls { get; set; }

	}
}

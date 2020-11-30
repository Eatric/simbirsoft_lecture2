using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Models.Responses.Cinema
{
	/// <summary>
	/// Ответ на запросы для сервисов кинотеатров
	/// </summary>
	public class CinemaResponse
	{
		/// <summary>
		/// Имя кинотеатра
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Адрес кинотеатра
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Количество кинозалов
		/// </summary>
		public byte NumberOfHalls { get; set; }
	}
}

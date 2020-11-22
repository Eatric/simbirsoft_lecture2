using System;

namespace SimbirSoft.API.Models.Domain
{
	/// <summary>
	/// Фильм
	/// </summary>
	public class Movie
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Название фильма
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Описание фильма
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Рейтинг фильма
		/// </summary>
		public double Rating { get; set; }

		/// <summary>
		/// Стоимость билета
		/// </summary>
		public double Cost { get; set; }

		/// <summary>
		/// Время показа
		/// </summary>
		public DateTime Date { get; set; }
	}
}

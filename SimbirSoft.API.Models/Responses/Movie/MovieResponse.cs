using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Models.Responses.Movie
{
	/// <summary>
	/// Ответ на запросы для сервисов кинофильмов
	/// </summary>
	public class MovieResponse
	{
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
	}
}

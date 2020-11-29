using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimbirSoft.API.Models.Requests.Movie
{
	/// <summary>
	/// Запрос на создание сущности кинофильма
	/// </summary>
	public class CreateMovieRequest
	{
		/// <summary>
		/// Название фильма
		/// </summary>
		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		/// <summary>
		/// Описание фильма
		/// </summary>
		[Required]
		[StringLength(500)]
		public string Description { get; set; }

		/// <summary>
		/// Рейтинг фильма
		/// </summary>
		[Required]
		public double Rating { get; set; }
	}
}

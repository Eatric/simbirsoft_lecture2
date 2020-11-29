using SimbirSoft.API.Database.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="Movie"/>
	/// </summary>
	public class MovieDTO
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

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Фильм
	/// </summary>
	public class Movie
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

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

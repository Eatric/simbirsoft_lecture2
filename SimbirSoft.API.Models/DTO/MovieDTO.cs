using SimbirSoft.API.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		[Required, MaxLength(64)]
		public string Name { get; set; }

		/// <summary>
		/// Описание фильма
		/// </summary>
		[Required, MaxLength(1000)]
		public string Description { get; set; }

		/// <summary>
		/// Рейтинг фильма
		/// </summary>
		[Required]
		public double Rating { get; set; }

		/// <summary>
		/// Стоимость билета на фильм
		/// </summary>
		[Required]
		public double Cost { get; set; }

		/// <summary>
		/// Время показа
		/// </summary>
		[Required]
		public DateTime Date { get; set; }
	}
}

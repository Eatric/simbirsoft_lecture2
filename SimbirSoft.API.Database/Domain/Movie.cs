using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Фильм
	/// </summary>
	public class Movie : BaseEntity
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

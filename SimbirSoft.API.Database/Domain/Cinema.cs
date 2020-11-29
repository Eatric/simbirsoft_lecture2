using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Кинотеатр
	/// </summary>
	public class Cinema : BaseEntity
	{
		/// <summary>
		/// Название кинотеатра
		/// </summary>
		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		/// <summary>
		/// Адрес кинотеатра
		/// </summary>
		[Required]
		[StringLength(200)]
		public string Address { get; set; }

		/// <summary>
		/// Количество кинозалов
		/// </summary>
		[Required]
		public byte NumberOfHalls { get; set; }
	}
}

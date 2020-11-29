using SimbirSoft.API.Database.Domain;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="Cinema"/>
	/// </summary>
	public class CinemaDTO
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

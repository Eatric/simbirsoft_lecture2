using SimbirSoft.API.Models.Domain;

using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Models.DTO
{
	public class CinemaDTO
	{
		[Required, MaxLength(64)]
		public string Name { get; set; }

		[Required, MaxLength(200)]
		public string Address { get; set; }

		[Required]
		public byte NumberOfHalls { get; set; }

		[Required]
		public Movie[] Movies { get; set; }
	}
}

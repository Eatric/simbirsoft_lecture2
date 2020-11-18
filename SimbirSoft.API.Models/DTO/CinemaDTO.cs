using SimbirSoft.API.Models.Domain;

namespace SimbirSoft.API.Models.DTO
{
	public class CinemaDTO
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public byte NumberOfHalls { get; set; }
		public Movie[] Movies { get; set; }
	}
}

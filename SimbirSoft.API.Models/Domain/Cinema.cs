namespace SimbirSoft.API.Models.Domain
{
	public class Cinema
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public byte NumberOfHalls { get; set; }
		public Movie[] Movies { get; set; }
	}
}

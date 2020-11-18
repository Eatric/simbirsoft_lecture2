using System;

namespace SimbirSoft.API.Models.Domain
{
	public class Movie
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Rating { get; set; }
		public decimal Cost { get; set; }
		public DateTime Date { get; set; }
	}
}

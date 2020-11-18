using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoft.API.Models.DTO
{
	public class MovieDTO
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public double Rating { get; set; }
		public decimal Cost { get; set; }
		public DateTime Date { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoft.API.Models.DTO
{
	public class MovieDTO
	{
		[Required, MaxLength(64)]
		public string Name { get; set; }

		[Required, MaxLength(1000)]
		public string Description { get; set; }

		[Required]
		public double Rating { get; set; }

		[Required]
		public double Cost { get; set; }

		[Required]
		public DateTime Date { get; set; }
	}
}

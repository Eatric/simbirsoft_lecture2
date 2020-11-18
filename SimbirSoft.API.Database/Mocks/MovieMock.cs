using SimbirSoft.API.Models.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Database.Mocks
{
	public static class MovieMock
	{
		public static IEnumerable<Movie> GetMovies()
		{
			var random = new Random();
			for (int i = 0; i < 5; i++)
			{
				yield return new Movie()
				{
					Id = random.Next(0, 1000),
					Cost = random.NextDouble() * 100,
					Name = random.NextDouble() * 10 + " " + random.Next(0, 1000),
					Description = random.NextDouble() * 10 + " " + random.Next(0, 1000),
					Rating = random.NextDouble() * 10,
					Date = DateTime.Today
				};
			}
		}
	}
}

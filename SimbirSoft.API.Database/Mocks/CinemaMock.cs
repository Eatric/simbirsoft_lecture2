using SimbirSoft.API.Models.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbirSoft.API.Database.Mocks
{
	public static class CinemaMock
	{
		public static IEnumerable<Cinema> GetCinemas()
		{
			var random = new Random();
			for (int i = 0; i < 3; i++)
			{
				yield return new Cinema()
				{
					Id = random.Next(0, 1000),
					Address = random.Next().GetHashCode().ToString(),
					Name = random.Next().GetHashCode().ToString(),
					NumberOfHalls = (byte)random.Next(0, 50),
					Movies = MovieMock.GetMovies().ToArray()
				};
			}
		}
	}
}

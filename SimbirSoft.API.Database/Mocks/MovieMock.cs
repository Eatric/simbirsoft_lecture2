using SimbirSoft.API.Database.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Database.Mocks
{
	/// <summary>
	/// Mock для работы с данными <see cref="Movie"/>
	/// </summary>
	public static class MovieMock
	{
		/// <summary>
		/// Метод для генерации объектов <see cref="Movie"/>
		/// </summary>
		/// <returns>Коллекция сущностей <see cref="Movie"/></returns>
		public static IEnumerable<Movie> GetMovies()
		{
			var random = new Random();
			for (int i = 0; i < 5; i++)
			{
				yield return new Movie()
				{
					Id = random.Next(0, 1000),
					Name = random.NextDouble() * 10 + " " + random.Next(0, 1000),
					Description = random.NextDouble() * 10 + " " + random.Next(0, 1000),
					Rating = random.NextDouble() * 10
				};
			}
		}
	}
}

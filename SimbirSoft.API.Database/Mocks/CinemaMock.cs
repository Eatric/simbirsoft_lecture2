using SimbirSoft.API.Database.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoft.API.Database.Mocks
{
	/// <summary>
	/// Mock для работы с <see cref="Cinema"/>
	/// </summary>
	public static class CinemaMock
	{
		/// <summary>
		/// Генерация случайных экземпляров объектов <see cref="Cinema"/>
		/// </summary>
		/// <returns>Коллекция сущностей <see cref="Cinema"/></returns>
		public static IEnumerable<Cinema> GetCinemas()
		{
			var random = new Random();
			for (int i = 0; i < 2; i++)
			{
				yield return new Cinema()
				{
					Id = random.Next(0, 1000),
					Address = random.Next().GetHashCode().ToString(),
					Name = random.Next().GetHashCode().ToString(),
					NumberOfHalls = (byte)random.Next(0, 50)
				};
			}
		}
	}
}

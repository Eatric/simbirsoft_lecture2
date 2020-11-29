using Microsoft.EntityFrameworkCore;

using SimbirSoft.API.Database.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Database.Contexts
{
	/// <summary>
	/// Контекст для работы с данными БД кинотеатра
	/// </summary>
	public class CinemaContext : DbContext
	{
		/// <summary>
		/// Кинотеатры
		/// </summary>
		public DbSet<Cinema> Cinemas { get; set; }

		/// <summary>
		/// Фильмы
		/// </summary>
		public DbSet<Movie> Movies { get; set; }

		/// <summary>
		/// Расписание кинофильмов
		/// </summary>
		public DbSet<Schedule> Schedules { get; set; }

		/// <summary>
		/// Кинобилеты
		/// </summary>
		public DbSet<Ticket> Tickets { get; set; }

		/// <summary>
		/// Инициализация экземпляра <see cref="CinemaContext"/>
		/// </summary>
		/// <param name="options">Опции для конфигурации контекста</param>
		public CinemaContext(DbContextOptions options) : base(options)
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}
	}
}

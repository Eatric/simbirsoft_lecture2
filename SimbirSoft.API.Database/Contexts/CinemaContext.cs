using Microsoft.EntityFrameworkCore;

using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Database.Fluent;

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
		/// Пользователи
		/// </summary>
		public DbSet<User> Users { get; set; }

		/// <summary>
		/// Роли
		/// </summary>
		public DbSet<Role> Roles { get; set; }

		/// <summary>
		/// Роли пользователей
		/// </summary>
		public DbSet<UserRoles> UserRoles { get; set; }

		/// <summary>
		/// Инициализация экземпляра <see cref="CinemaContext"/>
		/// </summary>
		/// <param name="options">Опции для конфигурации контекста</param>
		public CinemaContext(DbContextOptions options) : base(options)
		{ }

		/// <summary>
		/// Правила создания сущностей
		/// </summary>
		/// <param name="builder">Билдер моделей</param>
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new ScheduleConfig());
		}
	}
}

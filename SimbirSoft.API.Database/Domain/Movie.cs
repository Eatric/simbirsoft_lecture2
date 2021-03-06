﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Фильм
	/// </summary>
	public class Movie : BaseEntity
	{
		/// <summary>
		/// Название фильма
		/// </summary>
		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		/// <summary>
		/// Описание фильма
		/// </summary>
		[Required]
		[StringLength(500)]
		public string Description { get; set; }

		/// <summary>
		/// Режиссёр фильма
		/// </summary>
		[Required]
		[StringLength(150)]
		public string Producer { get; set; }

		/// <summary>
		/// Рейтинг фильма
		/// </summary>
		[Required]
		public double Rating { get; set; }

		/// <summary>
		/// Показывается ли этот фильм в каком либо кинотеатре
		/// </summary>
		public ICollection<Schedule> Schedules { get; set; }
	}
}

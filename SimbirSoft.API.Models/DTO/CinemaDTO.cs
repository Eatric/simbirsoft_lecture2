﻿using SimbirSoft.API.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="Cinema"/>
	/// </summary>
	public class CinemaDTO
	{
		/// <summary>
		/// Имя кинотеатра
		/// </summary>
		[Required, MaxLength(64)]
		public string Name { get; set; }

		/// <summary>
		/// Адрес кинотеатра
		/// </summary>
		[Required, MaxLength(200)]
		public string Address { get; set; }

		/// <summary>
		/// Количество кинозалов
		/// </summary>
		[Required]
		public byte NumberOfHalls { get; set; }

		/// <summary>
		/// Список фильмов для показа
		/// </summary>
		[Required]
		public MovieDTO[] Movies { get; set; }
	}
}

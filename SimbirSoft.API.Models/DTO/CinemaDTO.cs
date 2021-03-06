﻿using SimbirSoft.API.Database.Domain;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="Cinema"/>
	/// </summary>
	public class CinemaDTO : BaseDto
	{
		/// <summary>
		/// Имя кинотеатра
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Адрес кинотеатра
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Количество кинозалов
		/// </summary>
		public byte NumberOfHalls { get; set; }
	}
}

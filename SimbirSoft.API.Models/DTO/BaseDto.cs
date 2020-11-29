using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// Базовый класс для DTO
	/// </summary>
	public class BaseDto
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		[Required]
		public long Id { get; set; }
	}
}

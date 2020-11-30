using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimbirSoft.API.Models.Requests.Movie
{
	/// <summary>
	/// Запрос на обновление сущности
	/// </summary>
	public class UpdateMovieRequest : CreateMovieRequest
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		[Required]
		public long Id { get; set; }
	}
}

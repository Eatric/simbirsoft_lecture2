using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Models.Requests.Cinema
{
	/// <summary>
	/// Запрос на обновление информации о сущности кинотеатра
	/// </summary>
	public class UpdateCinemaRequest : CreateCinemaRequest
	{
		/// <summary>
		/// Идентификатор записи
		/// </summary>
		public long Id { get; set; }
	}
}

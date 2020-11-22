using SimbirSoft.API.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Services.Interfaces
{
	/// <summary>
	/// Интерфейс сервиса для работы с кинотеатрами.
	/// </summary>
	public interface ICinemaService
	{
		/// <summary>
		/// Метод для получения списка кинотеатров
		/// </summary>
		/// <returns>Список кинотеатров</returns>
		IEnumerable<CinemaDTO> GetCinemas();
	}
}

﻿using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces.CRUD;

namespace SimbirSoft.API.Services.Interfaces
{
	/// <summary>
	/// Интерфейс сервиса для работы с кинотеатрами.
	/// </summary>
	public interface ICinemaService : ICrudService<CinemaDTO>
	{
	}
}

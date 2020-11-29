using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;
using SimbirSoft.API.WebApp.Common.Swagger;

namespace SimbirSoft.API.WebApp.Controllers
{
	/// <summary>
	/// Контроллер для работы с кинотеатрами
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerGroups.Cinema)]
	public class CinemaController : ControllerBase
	{
		private readonly ILogger<CinemaController> _logger;
		private readonly ICinemaService _cinemaService;

		/// <summary>
		/// Инициализация контроллера для работы с данными кинотеатров
		/// </summary>
		/// <param name="cinemaService">Сервис для работы с кинотеатрами</param>
		/// <param name="logger">Сервис для логирования</param>
		public CinemaController(ICinemaService cinemaService, ILogger<CinemaController> logger)
		{
			_logger = logger;
			_cinemaService = cinemaService;
		}

		/// <summary>
		/// Получение списка кинотеатров
		/// </summary>
		/// <returns>Коллекция сущностей <see cref="CinemaDTO"/></returns>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CinemaDTO>))]
		public IActionResult Get()
		{
			_logger.LogInformation("GET /cinema request accepted");
			var response = _cinemaService.GetAsync();

			return Ok(response);
		}
	}
}

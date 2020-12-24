using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Models.Requests.Cinema;
using SimbirSoft.API.Models.Responses.Cinema;
using SimbirSoft.API.Services.Interfaces;
using SimbirSoft.API.WebApp.Common.Swagger;

namespace SimbirSoft.API.WebApp.Controllers
{
	/// <summary>
	/// Контроллер для работы с кинотеатрами
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[Authorize]
	public class CinemaController : ControllerBase
	{
		private readonly ILogger<CinemaController> _logger;
		private readonly ICinemaService _cinemaService;
		private readonly IMapper _mapper;

		/// <summary>
		/// Инициализация контроллера для работы с данными кинотеатров
		/// </summary>
		/// <param name="cinemaService">Сервис для работы с кинотеатрами</param>
		/// <param name="logger">Сервис для логирования</param>
		public CinemaController(ICinemaService cinemaService, ILogger<CinemaController> logger, IMapper mapper)
		{
			_logger = logger;
			_cinemaService = cinemaService;
			_mapper = mapper;
		}

		/// <summary>
		/// Получение списка кинотеатров
		/// </summary>
		/// <returns>Коллекция сущностей <see cref="CinemaResponse"/></returns>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CinemaResponse>))]
		public async Task<IActionResult> GetAll(CancellationToken token)
		{
			_logger.LogInformation("GET /cinema request accepted");
			var response = await _cinemaService.GetAsync(token);

			return Ok(_mapper.Map<IEnumerable<CinemaResponse>>(response));
		}

		/// <summary>
		/// Получение кинотеатра по идентификатору
		/// </summary>
		/// <returns>Сущность <see cref="CinemaResponse"/></returns>
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CinemaResponse))]
		public async Task<IActionResult> GetByIdAsync(long id, CancellationToken token)
		{
			_logger.LogInformation("GET /cinema/{id} request accepted");
			var response = await _cinemaService.GetAsync(id, token);

			return Ok(_mapper.Map<CinemaResponse>(response));
		}

		/// <summary>
		/// Создание новой сущности кинотеатра
		/// </summary>
		/// <returns>Сущность <see cref="CinemaResponse"/></returns>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CinemaResponse))]
		public async Task<IActionResult> CreateAsync(CreateCinemaRequest request, CancellationToken token)
		{
			_logger.LogInformation("POST /cinema request accepted");
			var response = await _cinemaService.CreateAsync(_mapper.Map<CinemaDTO>(request));

			return Ok(_mapper.Map<CinemaResponse>(response));
		}

		/// <summary>
		/// Обновление сущности кинотеатра
		/// </summary>
		/// <returns>Сущность <see cref="CinemaResponse"/></returns>
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CinemaResponse))]
		public async Task<IActionResult> UpdateAsync(UpdateCinemaRequest request, CancellationToken token)
		{
			_logger.LogInformation("PUT /cinema request accepted");
			var response = await _cinemaService.UpdateAsync(_mapper.Map<CinemaDTO>(request));

			return Ok(_mapper.Map<CinemaResponse>(response));
		}

		/// <summary>
		/// Удаление сущности кинотеатра
		/// </summary>
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public async Task<IActionResult> DeleteAsync(CancellationToken token, params long[] ids)
		{
			_logger.LogInformation("DELETE /cinema request accepted");
			await _cinemaService.DeleteAsync(ids);

			return NoContent();
		}
	}
}

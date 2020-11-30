using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Models.Requests.Movie;
using SimbirSoft.API.Models.Responses.Movie;
using SimbirSoft.API.Services.Interfaces;
using SimbirSoft.API.WebApp.Common.Swagger;

namespace SimbirSoft.API.WebApp.Controllers
{
	/// <summary>
	/// Контроллер для работы с кинофильмами
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerGroups.Cinema)]
	public class MovieController : ControllerBase
	{
		private readonly ILogger<MovieController> _logger;
		private readonly IMovieService _movieService;
		private readonly IMapper _mapper;

		/// <summary>
		/// Инициализация контроллера для работы с данными кинофильмами
		/// </summary>
		/// <param name="MovieService">Сервис для работы с кинофильмами</param>
		/// <param name="logger">Сервис для логирования</param>
		public MovieController(IMovieService MovieService, ILogger<MovieController> logger, IMapper mapper)
		{
			_logger = logger;
			_movieService = MovieService;
			_mapper = mapper;
		}

		/// <summary>
		/// Получение списка кинофильмов
		/// </summary>
		/// <returns>Коллекция сущностей <see cref="MovieResponse"/></returns>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MovieResponse>))]
		public async Task<IActionResult> GetAll(CancellationToken token)
		{
			_logger.LogInformation("GET /Movie request accepted");
			var response = await _movieService.GetAsync(token);

			return Ok(_mapper.Map<IEnumerable<MovieResponse>>(response));
		}

		/// <summary>
		/// Получение кинофильма по идентификатору
		/// </summary>
		/// <returns>Сущность <see cref="MovieResponse"/></returns>
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MovieResponse))]
		public async Task<IActionResult> GetByIdAsync(long id, CancellationToken token)
		{
			_logger.LogInformation("GET /Movie/{id} request accepted");
			var response = await _movieService.GetAsync(id, token);

			return Ok(_mapper.Map<MovieResponse>(response));
		}

		/// <summary>
		/// Создание новой сущности кинофильма
		/// </summary>
		/// <returns>Сущность <see cref="MovieResponse"/></returns>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MovieResponse))]
		public async Task<IActionResult> CreateAsync(CreateMovieRequest request, CancellationToken token)
		{
			_logger.LogInformation("POST /Movie request accepted");
			var response = await _movieService.CreateAsync(_mapper.Map<MovieDTO>(request));

			return Ok(_mapper.Map<MovieResponse>(response));
		}

		/// <summary>
		/// Обновление сущности кинофильма
		/// </summary>
		/// <returns>Сущность <see cref="MovieResponse"/></returns>
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MovieResponse))]
		public async Task<IActionResult> UpdateAsync(UpdateMovieRequest request, CancellationToken token)
		{
			_logger.LogInformation("PUT /Movie request accepted");
			var response = await _movieService.UpdateAsync(_mapper.Map<MovieDTO>(request));

			return Ok(_mapper.Map<MovieResponse>(response));
		}

		/// <summary>
		/// Удаление сущности кинофильма
		/// </summary>
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public async Task<IActionResult> DeleteAsync(CancellationToken token, params long[] ids)
		{
			_logger.LogInformation("DELETE /Movie request accepted");
			await _movieService.DeleteAsync(ids);

			return NoContent();
		}
	}
}

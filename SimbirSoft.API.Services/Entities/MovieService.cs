using Simbirsoft.API.Repositories;
using Simbirsoft.API.Repositories.Interfaces;
using Simbirsoft.API.Repositories.Interfaces.UOW;

using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;
using SimbirSoft.API.Services.Interfaces.CRUD;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SimbirSoft.API.Services.Entities
{
	/// <summary>
	/// Сервис для работы с данными кинофильмов
	/// </summary>
	public class MovieService : IMovieService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMovieRepository _repository;

		/// <summary>
		/// Инициализация сервиса <see cref="MovieService"/>
		/// </summary>
		/// <param name="unitOfWork">Класс для получения репозитория</param>
		public MovieService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			_repository = unitOfWork.GetRepository<MovieRepository>();
		}

		/// <inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		public async Task<MovieDTO> CreateAsync(MovieDTO dto)
		{
			return await _repository.CreateAsync(dto);
		}

		/// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
		public async Task DeleteAsync(params long[] ids)
		{
			await _repository.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<MovieDTO>> GetAsync(CancellationToken token = default)
		{
			return await _repository.GetAsync(token);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(long, CancellationToken)"/>
		public async Task<MovieDTO> GetAsync(long id, CancellationToken token = default)
		{
			return await _repository.GetAsync(id);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<MovieDTO> UpdateAsync(MovieDTO dto)
		{
			return await _repository.UpdateAsync(dto);
		}
	}
}

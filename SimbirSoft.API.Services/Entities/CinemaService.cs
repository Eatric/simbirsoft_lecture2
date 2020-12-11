using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;
using System.Collections.Generic;
using Simbirsoft.API.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using SimbirSoft.API.Services.Interfaces.CRUD;
using Simbirsoft.API.Repositories.Interfaces.UOW;
using Simbirsoft.API.Repositories;

namespace SimbirSoft.API.Services.Entities
{
	/// <summary>
	/// Сервис для работы с данными кинотеатров
	/// </summary>
	public class CinemaService : ICinemaService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly ICinemaRepository _repository;

		/// <summary>
		/// Инициализация сервиса <see cref="CinemaService"/>
		/// </summary>
		/// <param name="unitOfWork">Класс для получения репозитория</param>
		public CinemaService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			_repository = unitOfWork.GetRepository<CinemaRepository>();
		}

		/// <inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		public async Task<CinemaDTO> CreateAsync(CinemaDTO dto)
		{
			return await _repository.CreateAsync(dto);
		}

		/// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
		public async Task DeleteAsync(params long[] ids)
		{
			await _repository.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<CinemaDTO>> GetAsync(CancellationToken token = default)
		{
			return await _repository.GetAsync(token);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(long, CancellationToken)"/>
		public async Task<CinemaDTO> GetAsync(long id, CancellationToken token = default)
		{
			return await _repository.GetAsync(id);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<CinemaDTO> UpdateAsync(CinemaDTO dto)
		{
			return await _repository.UpdateAsync(dto);
		}
	}
}

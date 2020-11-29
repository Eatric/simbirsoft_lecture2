using AutoMapper;
using SimbirSoft.API.Database.Mocks;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simbirsoft.API.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using SimbirSoft.API.Services.Interfaces.CRUD;

namespace SimbirSoft.API.Services.Entities
{
	/// <summary>
	/// Сервис для работы с данными кинотеатров
	/// </summary>
	public class CinemaService : ICinemaService
	{
		private readonly ICinemaRepository _repository;

		/// <summary>
		/// Инициализация сервиса <see cref="CinemaService"/>
		/// </summary>
		/// <param name="repository">Репозиторий для работы с данными</param>
		public CinemaService(ICinemaRepository repository)
		{
			_repository = repository;
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

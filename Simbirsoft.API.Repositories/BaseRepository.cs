using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Simbirsoft.API.Repositories.Interfaces.CRUD;
using SimbirSoft.API.Database.Contexts;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories
{
    /// <inheritdoc cref="ICrudRepository{TDto, TModel}"/>
	public abstract class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel>
		where TModel : BaseEntity
        where TDto : BaseDto
	{
		protected readonly IMapper _mapper;
		protected readonly CinemaContext _context;
		protected DbSet<TModel> DbSet => _context.Set<TModel>();

        /// <summary>
        /// Инициализация экземпляра <see cref="BaseRepository{TDto, TModel}"/>
        /// </summary>
        /// <param name="cinemaContext">Контекст для данных</param>
        /// <param name="mapper">Маппер для сущностей</param>
		public BaseRepository(CinemaContext cinemaContext, IMapper mapper)
		{
			_mapper = mapper;
			_context = cinemaContext;
		}

        /// <inheritdoc cref="ICreatable{TDto, TModel}.CreateAsync(TDto)"/>
        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await DbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await GetAsync(entity.Id);
        }

        /// <inheritdoc cref="IDeletable.DeleteAsync(long[])"/>
        public async Task DeleteAsync(params long[] ids)
        {
            var entities = await DbSet
                                .Where(x => ids.Contains(x.Id))
                                .ToListAsync();

            _context.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc cref="IGettableById{TDto, TModel}.GetAsync(long)"/>
        public async Task<TDto> GetAsync(long id)
        {
            var entity = await DbSet
                              .AsNoTracking()
                              .FirstOrDefaultAsync(x => x.Id == id);

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        /// <inheritdoc cref="IUpdatable{TDto, TModel}.UpdateAsync(TDto, CancellationToken)"/>
        public async Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default)
        {
            var entity = _mapper.Map<TModel>(dto);
            _context.Update(entity);
            await _context.SaveChangesAsync(token);
            var newEntity = await GetAsync(entity.Id);

            return _mapper.Map<TDto>(newEntity);
        }

        /// <inheritdoc cref="IGettable{TDto, TModel}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default)
        {
            var entities = await DbSet.AsNoTracking().ToListAsync();

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return dtos;
        }
	}
}

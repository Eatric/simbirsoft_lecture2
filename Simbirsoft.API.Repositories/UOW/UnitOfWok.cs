using AutoMapper;
using Simbirsoft.API.Repositories.Interfaces.UOW;
using SimbirSoft.API.Database.Contexts;
using System;

namespace Simbirsoft.API.Repositories.UOW
{
    /// <inheritdoc cref="IUnitOfWork"/>
	public class UnitOfWork : IUnitOfWork
    {
        private readonly CinemaContext _databaseContext;
        private readonly IMapper _mapper;

        /// <summary>
        /// Конструктор для создания UOW
        /// </summary>
        /// <param name="dbContext">Контекст для данных</param>
        /// <param name="mapper">Маппер</param>
        public UnitOfWork(CinemaContext dbContext, IMapper mapper)
        {
            _databaseContext = dbContext;
            _mapper = mapper;
        }

        /// <inheritdoc cref="IUnitOfWork.GetRepository{T}"/>
        public T GetRepository<T>() where T : class
        {
            var result = (T)Activator.CreateInstance(typeof(T), _databaseContext, _mapper);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        /// <inheritdoc cref="IUnitOfWork.Save"/>
        public void Save()
        {
            _databaseContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _databaseContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}

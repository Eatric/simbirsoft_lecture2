using System;
using System.Collections.Generic;
using System.Text;

namespace Simbirsoft.API.Repositories.Interfaces.UOW
{
    /// <summary>
    /// Интерфейс для работы с разными репозиториями
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Метод получения репозитория
        /// </summary>
        /// <typeparam name="T">Класс для создания репозитория</typeparam>
        /// <returns>Созданный репозиторий</returns>
        T GetRepository<T>() where T : class;

        /// <summary>
        /// Сохранение данных в контексте
        /// </summary>
        void Save();
    }
}

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories.Interfaces.CRUD
{ 
	/// <summary>
	/// Интерфейс для получение списка всех сущностей
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	/// <typeparam name="TModel">Domain model</typeparam>
	public interface IGettable<TDto, TModel>
	{
		/// <summary>
		/// Список всех сущностей
		/// </summary>
		/// <param name="token">Токен операции <see cref="CancellationToken"/></param>
		/// <returns>Список всех сущностей</returns>
		Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default);
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimbirSoft.API.Services.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для получения сущностей
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	public interface IGettable<TDto>
	{
		/// <summary>
		/// Получение списка сущностей
		/// </summary>
		/// <param name="token">Токен операции <see cref="CancellationToken"/></param>
		/// <returns>Список сущностей</returns>
		Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default);
	}
}

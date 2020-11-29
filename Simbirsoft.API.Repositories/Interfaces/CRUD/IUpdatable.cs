using System.Threading;
using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для обновление информации о сущности
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	/// <typeparam name="TModel">Domain model</typeparam>
	public interface IUpdatable<TDto, TModel>
	{
		/// <summary>
		/// Обновление сущности
		/// </summary>
		/// <param name="dto">Сущность для обновления</param>
		/// <param name="token">Токен операции <see cref="CancellationToken"/></param>
		/// <returns>Обновленную сущность</returns>
		Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default);
	}
}

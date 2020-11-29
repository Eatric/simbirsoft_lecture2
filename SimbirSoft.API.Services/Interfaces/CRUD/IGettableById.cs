using System.Threading;
using System.Threading.Tasks;

namespace SimbirSoft.API.Services.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс получения сущности по идентификатору
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	public interface IGettableById<TDto>
	{
		/// <summary>
		/// Получение сущности по идентификатору
		/// </summary>
		/// <param name="id">Идентификатор сущности</param>
		/// <param name="token">Токен операции <see cref="CancellationToken"/></param>
		/// <returns>DTO выбранной сущности</returns>
		Task<TDto> GetAsync(long id, CancellationToken token = default);
	}
}

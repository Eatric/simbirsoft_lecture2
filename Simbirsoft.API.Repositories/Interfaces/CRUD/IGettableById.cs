using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для получения сущности по идентификатору
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	/// <typeparam name="TModel">Domain model</typeparam>
	public interface IGettableById<TDto, TModel>
	{
		/// <summary>
		/// Получение сущности
		/// </summary>
		/// <param name="id">Идентификатор требуемой сущности</param>
		/// <returns>DTO требуемой сущности</returns>
		Task<TDto> GetAsync(long id);
	}
}

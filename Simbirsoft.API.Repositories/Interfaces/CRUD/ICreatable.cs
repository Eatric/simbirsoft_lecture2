using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для создания сущности в БД
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	/// <typeparam name="TModel">Доменная модель</typeparam>
	public interface ICreatable<TDto, TModel>
	{
		/// <summary>
		/// Создание сущности
		/// </summary>
		/// <param name="model">DTO</param>
		/// <returns>Идентификатор созданной сущности</returns>
		Task<TDto> CreateAsync(TDto model);
	}
}

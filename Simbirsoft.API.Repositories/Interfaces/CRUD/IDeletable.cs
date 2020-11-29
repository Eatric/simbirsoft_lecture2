using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для удаления сущности
	/// </summary>
	public interface IDeletable
	{
		/// <summary>
		/// Удаление сущности
		/// </summary>
		/// <param name="ids">Список идентификаторов для удаления</param>
		Task DeleteAsync(params long[] ids);
	}
}

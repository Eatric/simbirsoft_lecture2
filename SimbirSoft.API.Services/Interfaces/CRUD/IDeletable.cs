using System.Threading.Tasks;

namespace SimbirSoft.API.Services.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для удаления сущности
	/// </summary>
	public interface IDeletable
	{
		/// <summary>
		/// Групповое удаление сущностей
		/// </summary>
		/// <param name="ids">Список идентификаторов для удаления</param>
		Task DeleteAsync(params long[] ids);
	}
}

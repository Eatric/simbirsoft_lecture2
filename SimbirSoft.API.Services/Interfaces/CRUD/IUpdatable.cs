using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoft.API.Services.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для обновления сущности
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	public interface IUpdatable<TDto>
	{
		/// <summary>
		/// Обновление сущности
		/// </summary>
		/// <param name="dto">Информация о сущности для обновления</param>
		/// <returns>Обновленная сущность</returns>
		Task<TDto> UpdateAsync(TDto dto);
	}
}

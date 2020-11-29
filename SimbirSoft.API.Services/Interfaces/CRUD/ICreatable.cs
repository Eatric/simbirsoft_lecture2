using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoft.API.Services.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для создания сущности
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	public interface ICreatable<TDto>
	{
		/// <summary>
		/// Создание сущности
		/// </summary>
		/// <param name="dto">DTO</param>
		/// <returns>Идентификатор созданной сущности</returns>
		Task<TDto> CreateAsync(TDto dto);
	}
}

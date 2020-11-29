using System;
using System.Collections.Generic;
using System.Text;

namespace Simbirsoft.API.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс для базового CRUD репозитория
	/// </summary>
	/// <typeparam name="TDto">DTO</typeparam>
	/// <typeparam name="TModel">Domain model</typeparam>
	public interface ICrudRepository<TDto, TModel> :
		ICreatable<TDto, TModel>,
		IGettable<TDto, TModel>,
		IGettableById<TDto, TModel>,
		IUpdatable<TDto, TModel>,
		IDeletable
	{
	}
}

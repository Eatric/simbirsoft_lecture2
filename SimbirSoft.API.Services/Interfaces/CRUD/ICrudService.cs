using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Services.Interfaces.CRUD
{
	/// <summary>
	/// Интерфейс сервиса с базовыми CRUD операциями
	/// </summary>
	/// <typeparam name="TDto"></typeparam>
	public interface ICrudService<TDto> :
		ICreatable<TDto>,
		IGettable<TDto>,
		IGettableById<TDto>,
		IUpdatable<TDto>,
		IDeletable
	{
	}
}

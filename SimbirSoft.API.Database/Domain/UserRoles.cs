using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Таблица связи многие ко многим
	/// </summary>
	public class UserRoles : BaseEntityWithTwoLinks<User, Role>
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public long Id { get; set; }
	}
}

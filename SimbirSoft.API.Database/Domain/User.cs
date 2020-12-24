using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Доменная модель для пользователя
	/// </summary>
	public class User : BaseEntity
	{
		/// <summary>
		/// Поле логина
		/// </summary>
		[Required]
		[StringLength(50)]
		public string Login { get; set; }

		/// <summary>
		/// Поле хэша пароля
		/// </summary>
		[Required]
		[StringLength(256)]
		public string Password { get; set; }

		/// <summary>
		/// Поле с солью пароля
		/// </summary>
		[Required]
		[StringLength(256)]
		public string Salt { get; set; }

		/// <summary>
		/// Поле с ролями пользователя
		/// </summary>
		public ICollection<Role> Roles { get; set; }
	}
}

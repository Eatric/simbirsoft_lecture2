using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimbirSoft.API.Database.Domain
{
	/// <summary>
	/// Доменная модель роли пользователя
	/// </summary>
	public class Role : BaseEntity
	{
		/// <summary>
		/// Название роли
		/// </summary>
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
	}
}

using SimbirSoft.API.Database.Domain;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="User"/>
	/// </summary>
	public class UserDTO : BaseDto
	{
		/// <summary>
		/// Поле логина
		/// </summary>
		public string Login { get; set; }

		/// <summary>
		/// Поле хэша пароля
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Соль пароля
		/// </summary>
		public string Salt { get; set; }
	}
}

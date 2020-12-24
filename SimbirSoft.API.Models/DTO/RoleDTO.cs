using SimbirSoft.API.Database.Domain;

namespace SimbirSoft.API.Models.DTO
{
	/// <summary>
	/// DTO для <see cref="Role"/>
	/// </summary>
	public class RoleDTO : BaseDto
	{
		/// <summary>
		/// Название роли
		/// </summary>
		public string Name { get; set; }
	}
}

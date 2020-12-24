using AutoMapper;

using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace SimbirSoft.API.Models.Mappings
{
	/// <summary>
	/// Mapping для <see cref="User"/>
	/// </summary>
	public class UserProfile : Profile
	{
		/// <summary>
		/// Метод инициализации маппинга для <see cref="User"/>
		/// </summary>
		public UserProfile()
		{
			CreateMap<User, UserDTO>().ReverseMap();
		}
	}
}

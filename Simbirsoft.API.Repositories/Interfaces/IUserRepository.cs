using Simbirsoft.API.Repositories.Interfaces.CRUD;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories.Interfaces
{
	/// <summary>
	/// Интерфейс репозитория для <see cref="User"/>
	/// </summary>
	public interface IUserRepository : ICrudRepository<UserDTO, User>
	{
		public Task<UserDTO> GetAsync(string userName);
		public Task<Role> GetRole(string userName);
	}
}

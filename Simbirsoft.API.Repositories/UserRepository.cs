using AutoMapper;

using Microsoft.EntityFrameworkCore;

using Simbirsoft.API.Repositories.Interfaces;
using SimbirSoft.API.Database.Contexts;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

using System.Linq;
using System.Threading.Tasks;

namespace Simbirsoft.API.Repositories
{
	/// <summary>
	/// Репозиторий для работы с <see cref="User"/>
	/// </summary>
	public class UserRepository : BaseRepository<UserDTO, User>, IUserRepository
	{
		/// <summary>
		/// Инициализирует экземпляр <see cref="UserRepository"/>
		/// </summary>
		/// <param name="context">Контекст данных</param>
		/// <param name="mapper">Маппер сущностей</param>
		public UserRepository(CinemaContext context, IMapper mapper) : base(context, mapper) { }

		public async Task<UserDTO> GetAsync(string userName)
		{
			var user = await DbSet.AsNoTracking().SingleOrDefaultAsync(x => x.Login == userName);

			return this._mapper.Map<User, UserDTO>(user);
		}

		public async Task<Role> GetRole(string userName)
		{
			var role = _context.UserRoles
				.Include(x => x.Entity1)
				.Include(x => x.Entity2)
				.SingleOrDefault(x => x.Entity1.Login == userName).Entity2;

			return role;
		}
	}
}

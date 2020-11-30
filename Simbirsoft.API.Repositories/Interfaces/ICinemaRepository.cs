using Simbirsoft.API.Repositories.Interfaces.CRUD;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace Simbirsoft.API.Repositories.Interfaces
{
	/// <summary>
	/// Интерфейс для репозитория <see cref="Cinema"/>
	/// </summary>
	public interface ICinemaRepository : ICrudRepository<CinemaDTO, Cinema>
	{
	}
}

using Simbirsoft.API.Repositories.Interfaces.CRUD;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;

namespace Simbirsoft.API.Repositories.Interfaces
{
	/// <summary>
	/// Интерфейс репозитория для <see cref="Movie"/>
	/// </summary>
	public interface IMovieRepository : ICrudRepository<MovieDTO, Movie>
	{
	}
}

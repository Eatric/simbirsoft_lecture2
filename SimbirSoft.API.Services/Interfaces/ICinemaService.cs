using SimbirSoft.API.Models.DTO;

using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Services.Interfaces
{
	public interface ICinemaService
	{
		IEnumerable<CinemaDTO> GetCinemas();
	}
}

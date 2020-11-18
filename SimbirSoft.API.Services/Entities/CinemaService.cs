using AutoMapper;

using SimbirSoft.API.Database.Mocks;
using SimbirSoft.API.Models.Domain;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbirSoft.API.Services.Entities
{
	public class CinemaService : ICinemaService
	{
		private readonly IMapper _mapper;
		private List<Cinema> _cinemas;

		public CinemaService(IMapper mapper)
		{
			_mapper = mapper;
			_cinemas = CinemaMock.GetCinemas().ToList();
		}

		public IEnumerable<CinemaDTO> GetCinemas()
		{
			var response = _mapper.Map<IEnumerable<CinemaDTO>>(_cinemas);

			return response;
		}

	}
}

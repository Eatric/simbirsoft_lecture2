using AutoMapper;
using SimbirSoft.API.Database.Mocks;
using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimbirSoft.API.Services.Entities
{
	/// <summary>
	/// Сервис для работы с данными кинотеатров
	/// </summary>
	public class CinemaService : ICinemaService
	{
		private readonly IMapper _mapper;
		private List<Cinema> _cinemas;

		/// <summary>
		/// Инициализация сервиса <see cref="CinemaService"/>
		/// </summary>
		/// <param name="mapper">Сервис для привидения DomainModels к DTO</param>
		public CinemaService(IMapper mapper)
		{
			_mapper = mapper;
			_cinemas = CinemaMock.GetCinemas().ToList();
		}

		/// <inheritdoc cref="ICinemaService"/>
		public IEnumerable<CinemaDTO> GetCinemas()	
		{
			var response = _mapper.Map<IEnumerable<CinemaDTO>>(_cinemas);

			return response;
		}

	}
}

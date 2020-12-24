using AutoMapper;

using SimbirSoft.API.Database.Domain;
using SimbirSoft.API.Models;
using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Models.Requests.Auth;
using SimbirSoft.API.Models.Responses.Auth;
using SimbirSoft.API.Models.Responses.User;

using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Services.Mappings
{
	/// <summary>
	/// Mapping запросов/ответов для <see cref="User"/>
	/// </summary>
	public class UserProfile : Profile
	{
		/// <summary>
		/// Метод инициализации маппинга запросов/ответов для <see cref="User"/>
		/// </summary>
		public UserProfile()
		{
			CreateMap<RefreshTokenRequest, UserDTO>();
			CreateMap<LoginRequest, UserDTO>();
			CreateMap<ImpersonationRequest, UserDTO>();
			CreateMap<UserDTO, JwtAuthResponse>();
			CreateMap<UserDTO, LoginResponse>();
			CreateMap<UserDTO, RefreshToken>();
		}
	}
}

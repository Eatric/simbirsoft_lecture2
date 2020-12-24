using SimbirSoft.API.Models.DTO;
using SimbirSoft.API.Services.Interfaces;
using System.Collections.Generic;
using Simbirsoft.API.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using SimbirSoft.API.Services.Interfaces.CRUD;
using Simbirsoft.API.Repositories.Interfaces.UOW;
using Simbirsoft.API.Repositories;
using System;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace SimbirSoft.API.Services.Entities
{
	/// <summary>
	/// Сервис для работы с данными пользователей
	/// </summary>
	public class UserService : IUserService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IUserRepository _repository;

		/// <summary>
		/// Инициализация сервиса <see cref="UserService"/>
		/// </summary>
		/// <param name="unitOfWork">Класс для получения репозитория</param>
		public UserService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
			_repository = unitOfWork.GetRepository<UserRepository>();
		}

		/// <summary>
		/// Генерация соли
		/// </summary>
		public static string Salt()
		{
			byte[] salt = new byte[256 / 8];
			using (var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(salt);
			}

			return Convert.ToBase64String(salt);
		}

		/// <summary>
		/// Метод хэшиования пароля
		/// </summary>
		/// <param name="pwd">Пароль необходимый захэшировать</param>
		/// <param name="salt">Соль</param>
		/// <param name="iterations">Количество итераций</param>
		/// <returns>Хэш пароля</returns>
		public static string PasswordHash(string pwd, string salt, int iterations = 10000)
		{
			var strResult = Convert.ToBase64String(KeyDerivation.Pbkdf2(
				password: pwd,
				salt: Convert.FromBase64String(salt),
				prf: KeyDerivationPrf.HMACSHA256,
				iterationCount: iterations,
				numBytesRequested: 512 / 8));

			return strResult;
		}

		public bool CreateUser(string userName, string password)
		{
			var salt = Salt();
			var task = _repository.CreateAsync(new UserDTO() { Login = userName, Password = PasswordHash(password, salt), Salt = salt});

			return task.GetAwaiter().IsCompleted;
		}

		public string GetUserRole(string userName)
		{
			return _repository.GetRole(userName).GetAwaiter().GetResult().Name; 
		}

		public bool IsExistUser(string userName)
		{
			return _repository.GetAsync(userName).GetAwaiter().GetResult() != null;
		}

		public bool IsValidUserCredentials(string userName, string password)
		{
			if (!IsExistUser(userName))
			{
				return false;
			}

			var user = _repository.GetAsync(userName).GetAwaiter().GetResult();

			return user.Password == PasswordHash(password, user.Salt);	
		}
	}
}

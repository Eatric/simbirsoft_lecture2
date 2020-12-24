using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoft.API.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с пользователями
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Существование пользователя
        /// </summary>
        bool IsExistUser(string userName);

        /// <summary>
        /// Проверка введенных данных
        /// </summary>
        bool IsValidUserCredentials(string userName, string password);

        /// <summary>
        /// Получение роли пользователя, если существует
        /// </summary>
        string GetUserRole(string userName);

        /// <summary>
        /// Создание нового пользователя
        /// </summary>
        bool CreateUser(string userName, string password);
    }
}

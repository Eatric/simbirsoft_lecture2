using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimbirSoft.API.Models.Requests.Auth
{
	/// <summary>
	/// Запрос для авторизации
	/// </summary>
	public class LoginRequest
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        [Required]
        [JsonPropertyName("login")]
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}

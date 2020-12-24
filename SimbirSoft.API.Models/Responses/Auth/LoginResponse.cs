using System.Text.Json.Serialization;

namespace SimbirSoft.API.Models.Responses.User
{
	/// <summary>
	/// Ответ после авторизации
	/// </summary>
	public class LoginResponse
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }
}

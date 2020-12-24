using System.Text.Json.Serialization;

namespace SimbirSoft.API.Models.Requests.Auth
{
	/// <summary>
	/// Запрос для обновления токена
	/// </summary>
	public class RefreshTokenRequest
    {
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }

}

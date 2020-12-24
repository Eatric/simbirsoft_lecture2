using System.Text.Json.Serialization;

namespace SimbirSoft.API.Models.Responses.Auth
{
	/// <summary>
	/// Модель токенов
	/// </summary>
	public class JwtAuthResponse
    {
        /// <summary>
        /// AT токен
        /// </summary>
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

		/// <summary>
		/// RT.
		/// </summary>
		[JsonPropertyName("refreshToken")]
        public RefreshToken RefreshToken { get; set; }
    }

}

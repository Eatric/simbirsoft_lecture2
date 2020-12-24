using System.Text.Json.Serialization;

namespace Simbirsoft.API.Infrastructure.Bootstrap
{
	/// <summary>
	/// Конфигурация токена из appsettings
	/// </summary>
	public class JwtTokenConfig
    {
        /// <summary>
        /// Secret.
        /// </summary>
        [JsonPropertyName("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Issuer.
        /// </summary>
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// Audience.
        /// </summary>
        [JsonPropertyName("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// AT time.
        /// </summary>
        [JsonPropertyName("accessTokenExpiration")]
        public int AccessTokenExpiration { get; set; }

        /// <summary>
        /// RT time.
        /// </summary>
        [JsonPropertyName("refreshTokenExpiration")]
        public int RefreshTokenExpiration { get; set; }
    }
}

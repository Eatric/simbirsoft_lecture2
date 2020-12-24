using System.Text.Json.Serialization;

namespace SimbirSoft.API.Models.Requests.Auth
{
	/// <summary>
	/// Запрос для уничтожения сессии
	/// </summary>
	public class ImpersonationRequest
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }
    }
}

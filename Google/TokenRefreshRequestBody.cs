using Newtonsoft.Json;

namespace DevBot.Google
{
    public class TokenRefreshRequestBody
    {
        public TokenRefreshRequestBody(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        [JsonProperty("token_uri")]
        public string TokenUri { get; set; } = "https://oauth2.googleapis.com/token";
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}

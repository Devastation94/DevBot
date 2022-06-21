using Newtonsoft.Json;

namespace DevBot.Google
{
    public class TokenRefreshResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("Request")]
        public Request Request { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("Response")]
        public Response Response { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
    public class Headers
    {
        [JsonProperty("Content-length")]
        public string ContentLength { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("user-agent")]
        public string UserAgent { get; set; }

        [JsonProperty("X-xss-protection")]
        public string XXssProtection { get; set; }

        [JsonProperty("X-content-type-options")]
        public string XContentTypeOptions { get; set; }

        [JsonProperty("Transfer-encoding")]
        public string TransferEncoding { get; set; }

        [JsonProperty("Expires")]
        public string Expires { get; set; }

        [JsonProperty("Vary")]
        public string Vary { get; set; }

        [JsonProperty("Server")]
        public string Server { get; set; }

        [JsonProperty("-content-encoding")]
        public string ContentEncoding { get; set; }

        [JsonProperty("Pragma")]
        public string Pragma { get; set; }

        [JsonProperty("Cache-control")]
        public string CacheControl { get; set; }

        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("X-frame-options")]
        public string XFrameOptions { get; set; }

        [JsonProperty("Alt-svc")]
        public string AltSvc { get; set; }
    }

    public class Request
    {
        [JsonProperty("abs_path")]
        public string AbsPath { get; set; }

        [JsonProperty("absoluteUri")]
        public string AbsoluteUri { get; set; }

        [JsonProperty("HTTP-Version")]
        public string HTTPVersion { get; set; }

        [JsonProperty("headers")]
        public Headers Headers { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("message-body")]
        public string MessageBody { get; set; }

        [JsonProperty("Method")]
        public string Method { get; set; }
    }

    public class Response
    {
        [JsonProperty("Reason-Phrase")]
        public string ReasonPhrase { get; set; }

        [JsonProperty("HTTP-Version")]
        public string HTTPVersion { get; set; }

        [JsonProperty("headers")]
        public Headers Headers { get; set; }

        [JsonProperty("message-body")]
        public string MessageBody { get; set; }

        [JsonProperty("Status-Code")]
        public int StatusCode { get; set; }

        [JsonProperty("is-binary")]
        public bool IsBinary { get; set; }
    }
}

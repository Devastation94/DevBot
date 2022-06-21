using DevBot.Helpers;
using Newtonsoft.Json;

namespace DevBot.Google
{
    public static class Fit
    {
        public static int GetSteps()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {GetRefreshedToken()}");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                var date = DateTime.Now;

                var startDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0).ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                var endDate = new DateTime(date.Year, date.Month, date.Day, 20, 0, 0).ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                var interval = 72000000;

                var root = new StepsRequestBody(startDate, endDate, interval);

                var body = JsonConvert.SerializeObject(root);

                var result = client.PostAsync("https://www.googleapis.com/fitness/v1/users/me/dataset:aggregate", new StringContent(body)).Result.Content.ReadAsStringAsync().Result;

                var response = JsonConvert.DeserializeObject<StepsResponseContent>(result);

                return response?.Bucket[0]?.Dataset[0]?.Point[0]?.Value[0]?.IntVal ?? throw new Exception();
            }
        }

        private static string GetRefreshedToken()
        {
            var refreshToken = ConfigHelper.GetSecuredConfigValue<string>("RefreshToken");

            using (var client = new HttpClient())
            {
                var body = JsonConvert.SerializeObject(new TokenRefreshRequestBody(refreshToken));
                var result = client.PostAsync("https://developers.google.com/oauthplayground/refreshAccessToken", new StringContent(body)).Result.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<TokenRefreshResponse>(result)?.AccessToken ?? throw new Exception();
            }
        }
    }
}
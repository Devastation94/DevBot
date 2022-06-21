using DevBot.Helpers;
using Discord.Webhook;

namespace DevBot.Discord
{
    public static class WebhookHelper
    {
        private static readonly ulong WebHookId = ConfigHelper.GetSecuredConfigValue<ulong>("WebHookId");
        private static readonly string WebHookToken = ConfigHelper.GetSecuredConfigValue<string>("WebHookToken");

        public static void PostMessage(string steps)
        {
            using (var client = new DiscordWebhookClient(WebHookId, WebHookToken))
            {
                //client.SendMessageAsync($"Walked {steps} steps today!");
            }
        }
    }
}
using DevBot.Discord;
using DevBot.Google;
using Microsoft.Extensions.Configuration;

public class Program
{
    public static void Main()
    {
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

        var secretProvider = config.Providers.First();
        secretProvider.TryGet("RefreshToken", out var secretPass);

        WebhookHelper.PostMessage(Fit.GetSteps().ToString());
    }
}
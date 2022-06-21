using DevBot.Discord;
using DevBot.Google;
using Microsoft.Extensions.Configuration;

public class Program
{
    public static void Main()
    {
        WebhookHelper.PostMessage(Fit.GetSteps().ToString());
    }
}
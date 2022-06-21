using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBot.Helpers
{
    public static class ConfigHelper
    {
        private static readonly IConfigurationRoot config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        private static readonly IConfigurationProvider secretProvider = config.Providers.First();

        public static T GetSecuredConfigValue<T>(string key)
        {
            secretProvider.TryGet(key, out string value);
            return (T) Convert.ChangeType(value, typeof (T));
        }
    }
}

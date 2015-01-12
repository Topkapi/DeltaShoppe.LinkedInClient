using System.Configuration;

namespace DeltaShoppe.LinkedInClient
{
    public class LinkedInConfiguration
    {
        public string ApiKey { get; private set; }

        public string ApiSecret { get; private set; }

        public string RedirectUri { get; private set; }

        private static readonly LinkedInConfiguration Configuration = new LinkedInConfiguration();

        // To make this class a singleton
        private LinkedInConfiguration()
        {
            var apiKey = ConfigurationManager.AppSettings["LinkedInApiKey"];
            if (string.IsNullOrEmpty(apiKey)) throw new ConfigurationErrorsException("You must specify a LinkedInApiKey in appSettings in the config file");

            var secret = ConfigurationManager.AppSettings["LinkedInApiSecret"];
            if (string.IsNullOrEmpty(secret)) throw new ConfigurationErrorsException("You must specify a LinkedInApiSecret in appSettings in the config file");

            var redirectUri = ConfigurationManager.AppSettings["LinkedInApiRedirectUri"];
            if (string.IsNullOrEmpty(secret)) throw new ConfigurationErrorsException("You must specify a LinkedInApiRedirectUri in appSettings in the config file");

            ApiKey = apiKey;
            ApiSecret = secret;
            RedirectUri = redirectUri;
        }

        // To Force Laziness - Do not delete it.
        static LinkedInConfiguration() { }


        public static LinkedInConfiguration Instance
        {
            get { return Configuration; }
        }
    }
}

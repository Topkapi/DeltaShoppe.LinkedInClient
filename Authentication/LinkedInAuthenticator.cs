using System;
using System.Net.Http;
using DeltaShoppe.LinkedInClient.Api.Contracts;
using Newtonsoft.Json.Linq;

namespace DeltaShoppe.LinkedInClient.Authentication
{
    public class LinkedInAuthenticator : HttpClient, ILinkedInAuthenticator
    {
        private const string UrlToGetAuthenticationCode =
            "https://www.linkedin.com/uas/oauth2/authorization?response_type=code&scope=r_basicprofile%20r_network%20w_messages&client_id={0}&state={1}&redirect_uri={2}";

        private const string UrlToGetAccessToken =
            "https://www.linkedin.com/uas/oauth2/accessToken?grant_type=authorization_code&code={0}&redirect_uri={1}&client_id={2}&client_secret={3}";


        public LinkedInAuthenticator()
        {
            DefaultRequestHeaders.Add("x-li-format", "json");
        }

        public AccessTokenDetails AccessTokenDetails { get; set; }

        public AccessTokenDetails FetchAccessToken(string code)
        {
            var config = LinkedInConfiguration.Instance;

            var fullPath = string.Format(UrlToGetAccessToken, code, config.RedirectUri, config.ApiKey, config.ApiSecret);

            //The content (the HTTP POST body) will be empty as all the values are being passed through the query string. It's how the LinkedIn API wants it.
            var emptyContent = new StringContent("");
            var response = new HttpResponseMessage();
            PostAsync(fullPath, emptyContent).ContinueWith(responseMessage =>
            {
                response = responseMessage.Result;
            }).Wait();

            var content = "";
            response.Content.ReadAsStringAsync().ContinueWith(stringContent =>
            {
                content = stringContent.Result;
            }).Wait();

            dynamic deserialized = JToken.Parse(content);
            AccessTokenDetails = new AccessTokenDetails
            {
                AccessToken = deserialized.access_token,
                ExpiresOn = DateTime.Now.AddSeconds(((int) deserialized.expires_in))
            };
            return AccessTokenDetails;
        }

        public LinkedInAuthenticationPath GetAuthenticationPath()
        {
            var config = LinkedInConfiguration.Instance;
            var state = Guid.NewGuid();

            var path = string.Format(UrlToGetAuthenticationCode, config.ApiKey, state, config.RedirectUri);
            return new LinkedInAuthenticationPath
            {
                Path = path,
                State = state
            };
        }
    }
}

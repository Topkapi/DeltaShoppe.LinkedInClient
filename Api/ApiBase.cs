using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DeltaShoppe.LinkedInClient.Api.Contracts;
using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.Api
{
    public abstract class ApiBase : HttpClient
    {
        public readonly ILinkedInAuthenticator Authenticator;

        protected ApiBase(ILinkedInAuthenticator authenticator)
        {
            Authenticator = authenticator;
            if (authenticator == null)
            {
                throw new InvalidOperationException("You must pass a valid LinkedInAuthenticator instance when accessing linked in client");
            }

            DefaultRequestHeaders.Add("x-li-format", "json");
            BaseAddress = new Uri("https://api.linkedin.com/");
        }

        protected async Task<T> GetAsync<T>(string relativePath) where T : class
        {
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Authenticator.AccessTokenDetails.AccessToken);
            var response = GetAsync(relativePath);
            if (response.Result.IsSuccessStatusCode)
            {
                var respJson = await response.Result.Content.ReadAsStringAsync();
                var jobject = JsonConvert.DeserializeObject<T>(respJson);
                return jobject;
            }
            return null;
        }

        protected async Task<bool> PostAsync<T>(T data, string relativePath) where T : class
        {
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Authenticator.AccessTokenDetails.AccessToken);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            var content = new StringContent(json);

            var response = await PostAsync(relativePath, content);
            return response.IsSuccessStatusCode;
        }
    }
}

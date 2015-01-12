using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.Api
{
    public abstract class ApiBase : HttpClient
    {
        protected string AccessToken;

        protected ApiBase(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
            {
                throw new InvalidOperationException("You must pass an access token when accessing linked in client");
            }

            DefaultRequestHeaders.Add("x-li-format", "json");
            BaseAddress = new Uri("https://api.linkedin.com/");
            AccessToken = accessToken;
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        protected async Task<T> GetAsync<T>(string relativePath) where T : class
        {
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
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            var content = new StringContent(json);

            var response = await PostAsync(relativePath, content);
            return response.IsSuccessStatusCode;
        }
    }
}

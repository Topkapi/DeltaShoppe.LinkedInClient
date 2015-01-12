using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto
{
    public class JsonKeyValue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
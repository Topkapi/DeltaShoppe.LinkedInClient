using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto
{
    public class Company
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
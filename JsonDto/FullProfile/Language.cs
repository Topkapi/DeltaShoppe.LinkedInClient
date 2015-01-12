using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto.FullProfile
{
    public class Language
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("language")]
        public LanguageDetails LanguageDetails { get; set; }
    }

    public class LanguageDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
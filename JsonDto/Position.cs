using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto
{
    public class Position
    {
        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isCurrent")]
        public bool IsCurrent { get; set; }

        [JsonProperty("startDate")]
        public LinkedInDate StartDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("endDate")]
        public LinkedInDate EndDate { get; set; }
    }
}
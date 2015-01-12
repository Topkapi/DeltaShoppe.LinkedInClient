using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto.FullProfile
{
    public class Recommendation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("recommendationText")]
        public string RecommendationText { get; set; }

        [JsonProperty("recommendationType")]
        public RecommendationType RecommendationType { get; set; }

        [JsonProperty("recommender")]
        public Recommender Recommender { get; set; }
    }

    public class Recommender
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class RecommendationType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
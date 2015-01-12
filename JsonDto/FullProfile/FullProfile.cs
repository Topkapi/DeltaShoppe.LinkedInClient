using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto.FullProfile
{
    public class FullProfile : BasicProfile
    {
        [JsonProperty("certifications")]
        public JsonList<JsonKeyValue> Certifications { get; set; }

        [JsonProperty("courses")]
        public JsonList<JsonKeyValue> Courses { get; set; }

        [JsonProperty("dateOfBirth")]
        public LinkedInDate DateOfBirth { get; set; }

        [JsonProperty("educations")]
        public JsonList<Education> Educations { get; set; }

        [JsonProperty("honorsAwards")]
        public JsonList<JsonKeyValue> HonorsAwards { get; set; }

        [JsonProperty("interests")]
        public string Interests { get; set; }

        [JsonProperty("languages")]
        public JsonList<Language> Languages { get; set; }

        [JsonProperty("numRecommenders")]
        public int NumberOfRecommenders { get; set; }

        [JsonProperty("recommendationsReceived")]
        public JsonList<Recommendation> RecommendationsReceived { get; set; }

        [JsonProperty("skills")]
        public JsonList<Skill> Skills { get; set; }
    }
}

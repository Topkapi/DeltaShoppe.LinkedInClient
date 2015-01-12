using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto.FullProfile
{
    public class Skill
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("skill")]
        public SkillDetails SkillDetails { get; set; }
    }

    public class SkillDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
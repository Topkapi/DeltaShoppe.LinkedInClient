using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto.FullProfile
{
    public class Education
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("fieldOfStudy")]
        public string FieldOfStudy { get; set; }

        [JsonProperty("schoolName")]
        public string SchoolName { get; set; }
    }
}
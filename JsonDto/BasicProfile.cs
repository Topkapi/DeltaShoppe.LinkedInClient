using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto
{
    public class BasicProfile
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("maidenName")]
        public string MaidenName { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("formattedName")]
        public string FormattedName { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("numConnections")]
        public int NumberOfConnections { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("positions")]
        public PositionList Positions { get; set; }

        [JsonProperty("pictureUrl")]
        public string PictureUrl { get; set; }

        [JsonProperty("publicProfileUrl")]
        public string PublicProfileUrl { get; set; }

        [JsonProperty("specialities")]
        public string Specialities { get; set; }
    }
}

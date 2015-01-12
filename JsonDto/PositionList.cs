using System.Collections.Generic;
using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto
{
    public class PositionList
    {
        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("values")]
        public List<Position> Positions { get; set; }
    }
}
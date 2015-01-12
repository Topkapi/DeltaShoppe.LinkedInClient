using System.Collections.Generic;
using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto
{
    public class JsonList<T>
    {
        public int? Count { get; set; }

        public int? Start { get; set; }

        [JsonProperty("_total")]
        public int Total { get; set; }

        [JsonProperty("values")]
        public List<T> Values { get; set; }
    }
}

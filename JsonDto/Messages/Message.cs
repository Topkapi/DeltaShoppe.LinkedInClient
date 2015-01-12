using Newtonsoft.Json;

namespace DeltaShoppe.LinkedInClient.JsonDto.Messages
{
    /// <summary>
    /// This class is used to send message from the logged in LinkedIn user to his or her connections
    /// The objects of this class get serialized and sent to linked in api
    /// </summary>
    public class Message
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("recipients")]
        public JsonList<MessageRecipient> Recipients { get; set; }
    }

    public class MessageRecipient
    {
        [JsonProperty("person")]
        public LinkedInPerson Person { get; set; }
    }

    public class LinkedInPerson
    {
        [JsonProperty("_path")]
        public string Path { get; set; }
    }
}

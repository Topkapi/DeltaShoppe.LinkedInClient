using DeltaShoppe.LinkedInClient.Api.Contracts;

namespace DeltaShoppe.LinkedInClient.Api
{
    public class LinkedInManager : ILinkedInManager
    {
        public LinkedInManager(string accessToken)
        {
            Profile = new LinkedInProfile(accessToken);
            Connections = new LinkedInConnections(accessToken);
            Messages = new LinkedInMessages(accessToken);
        }
        
        public ILinkedInProfile Profile { get; set; }
        public ILinkedInConnections Connections { get; set; }
        public ILinkedInMessages Messages { get; set; }
    }
}

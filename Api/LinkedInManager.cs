using DeltaShoppe.LinkedInClient.Api.Contracts;

namespace DeltaShoppe.LinkedInClient.Api
{
    public class LinkedInManager : ILinkedInManager
    {
        public LinkedInManager(ILinkedInAuthenticator linkedInAuthenticator, ILinkedInProfile linkedInProfile, ILinkedInConnections linkedInConnections, ILinkedInMessages linkedInMessages)
        {
            Authenticator = linkedInAuthenticator;
            Profile = linkedInProfile;
            Connections = linkedInConnections;
            Messages = linkedInMessages;
        }
        
        public ILinkedInProfile Profile { get; private set; }
        public ILinkedInConnections Connections { get; private set; }
        public ILinkedInMessages Messages { get; private set; }

        public ILinkedInAuthenticator Authenticator { get; private set; }
    }
}

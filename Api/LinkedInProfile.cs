using DeltaShoppe.LinkedInClient.Api.Contracts;
using DeltaShoppe.LinkedInClient.JsonDto;
using DeltaShoppe.LinkedInClient.JsonDto.FullProfile;

namespace DeltaShoppe.LinkedInClient.Api
{
    public class LinkedInProfile : ApiBase, ILinkedInProfile
    {
        public LinkedInProfile(ILinkedInAuthenticator authenticator) : base(authenticator)
        {
        }

        public BasicProfile GetBasicProfile()
        {
            throw new System.NotImplementedException();
        }

        public BasicProfile GetBasicProfile(int id)
        {
            throw new System.NotImplementedException();
        }

        public FullProfile GetFullProfile()
        {
            throw new System.NotImplementedException();
        }

        public FullProfile GetFullProfile(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
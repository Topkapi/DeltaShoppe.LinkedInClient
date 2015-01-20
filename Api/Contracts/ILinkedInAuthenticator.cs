using DeltaShoppe.LinkedInClient.Authentication;

namespace DeltaShoppe.LinkedInClient.Api.Contracts
{
    public interface ILinkedInAuthenticator
    {
        AccessTokenDetails AccessTokenDetails { get; set; }

        AccessTokenDetails FetchAccessToken(string code);
        LinkedInAuthenticationPath GetAuthenticationPath();
    }
}
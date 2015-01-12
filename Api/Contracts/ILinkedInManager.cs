namespace DeltaShoppe.LinkedInClient.Api.Contracts
{
    /// <summary>
    /// This is the top level of the API and preferrably this is where the client code will get access to the api
    /// There should be a minimum need to get down to other classes except the ones which are referenced as part of the API access.
    /// </summary>
    public interface ILinkedInManager
    {
        ILinkedInProfile Profile { get; set; }

        ILinkedInConnections Connections { get; set; }

        ILinkedInMessages Messages { get; set; }
    }
}
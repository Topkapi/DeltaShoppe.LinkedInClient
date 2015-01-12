using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeltaShoppe.LinkedInClient.Api.Contracts
{
    public interface ILinkedInMessages
    {
        Task<bool> SendMessage(IEnumerable<string> recipients, string subject, string message);
    }
}
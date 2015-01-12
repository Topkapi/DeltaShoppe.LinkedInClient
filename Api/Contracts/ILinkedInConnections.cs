using System.Collections.Generic;
using System.Threading.Tasks;
using DeltaShoppe.LinkedInClient.JsonDto;

namespace DeltaShoppe.LinkedInClient.Api.Contracts
{
    public interface ILinkedInConnections
    {
        Task<JsonList<BasicProfile>> GetAllAsync(int? start=null, int? count=null);
        void SendMessage(string subject, string body, IEnumerable<int> ids);
    }
}
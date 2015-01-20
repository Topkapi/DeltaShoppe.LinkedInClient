using System.Collections.Generic;
using System.Threading.Tasks;
using DeltaShoppe.LinkedInClient.Api.Contracts;
using DeltaShoppe.LinkedInClient.JsonDto;

namespace DeltaShoppe.LinkedInClient.Api
{
    public class LinkedInConnections : ApiBase, ILinkedInConnections
    {
        public LinkedInConnections(ILinkedInAuthenticator authenticator) : base(authenticator)
        {
        }

        public async Task<JsonList<BasicProfile>> GetAllAsync(int? start = null, int? count = null )
        {
            string path = "v1/people/~/connections";
            if (start != null || count != null)
            {
                path = path + string.Format("?start={0}&count={1}", start, count);
            }
            return await GetAsync<JsonList<BasicProfile>>(path);
        }

        public void SendMessage(string subject, string body, IEnumerable<int> ids)
        {
            throw new System.NotImplementedException();
        }
    }
}
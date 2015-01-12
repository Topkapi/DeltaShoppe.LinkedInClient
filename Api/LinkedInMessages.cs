using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeltaShoppe.LinkedInClient.Api.Contracts;
using DeltaShoppe.LinkedInClient.JsonDto;
using DeltaShoppe.LinkedInClient.JsonDto.Messages;

namespace DeltaShoppe.LinkedInClient.Api
{
    public class LinkedInMessages : ApiBase, ILinkedInMessages
    {
        public LinkedInMessages(string accessToken) : base(accessToken)
        {
        }

        public async Task<bool> SendMessage(IEnumerable<string> recipients, string subject, string message)
        {
            var linkedInMessage = new Message
            {
                Subject = subject,
                Body = message,
                Recipients = new JsonList<MessageRecipient>
                {
                    Values = recipients.Select(x => new MessageRecipient { Person = new LinkedInPerson { Path = "/people/" + x } }).ToList()
                }
            };
            bool result = await PostAsync(linkedInMessage, "v1/people/~/mailbox");
            return result;
        }
    }
}
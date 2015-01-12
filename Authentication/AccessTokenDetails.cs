using System;

namespace DeltaShoppe.LinkedInClient.Authentication
{
    public class AccessTokenDetails
    {
        public string AccessToken { get; set; }

        public DateTime? ExpiresOn { get; set; }
    }
}

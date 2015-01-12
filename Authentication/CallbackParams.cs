using System;

namespace DeltaShoppe.LinkedInClient.Authentication
{
    public class CallbackParams
    {
        public string Code { get; set; }
        
        public Guid? State { get; set; }

        public string Error { get; set; }

        public string Error_Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveMailInfo
{
    public class Email
    {
        public string EmailId { get; set; }
        public string SenderEmailAddress { get; set; }
        public string Cc { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateSend { get; set; }
    }
}

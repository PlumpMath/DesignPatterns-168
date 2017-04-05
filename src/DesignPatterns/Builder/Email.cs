using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Email
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string SenderName { get; set; }
        public List<string> Recipients { get; set; }
    }
}
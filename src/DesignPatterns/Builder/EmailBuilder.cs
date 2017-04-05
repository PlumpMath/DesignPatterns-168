using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class EmailBuilder : IEmptyEmailBuilder
    {
        public IEmailWithBodyBuilder SetBody(string newBody)
        {
            return new CompleteEmailBuilder().SetBody(newBody);
        }

        public IEmailWithRecipientBuilder AddRecipient(string recipientName)
        {
            return new CompleteEmailBuilder().AddRecipient(recipientName);
        }

        private class CompleteEmailBuilder : ICompleteEmailBuilder
        {
            private string _subject;
            private string _sender;
            private string _body;
            private readonly List<string> _recipients = new List<string>();

            public ICompleteEmailBuilder AddRecipient(string recipientName)
            {
                _recipients.Add(recipientName);
                return this;
            }

            public ICompleteEmailBuilder SetBody(string newBody)
            {
                _body = newBody;
                return this;
            }

            public ICompleteEmailBuilder SetSubject(string subject)
            {
                _subject = subject;
                return this;
            }

            public ICompleteEmailBuilder SetSender(string sender)
            {
                _sender = sender;
                return this;
            }

            public Email GetResult()
            {
                return new Email
                {
                    Body = _body,
                    Recipients = _recipients,
                    SenderName = _sender,
                    Subject = _subject
                };
            }
        }
    }
}

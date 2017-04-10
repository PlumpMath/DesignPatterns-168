using System;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class AnounymousChatClientDecorator : IChatClient
    {
        private readonly IChatClient _chatClient;

        public AnounymousChatClientDecorator(IChatClient chatClient)
        {
            _chatClient = chatClient;
        }

        public void SendMessage(Message message)
        {
            message.Receiver = Encoding.UTF8.GetString(Convert.FromBase64String(message.Receiver));
            message.Sender = Encoding.UTF8.GetString(Convert.FromBase64String(message.Sender));
            _chatClient.SendMessage(message);
        }

        public void ReceiveMessage(Message message)
        {
            message.Receiver = Convert.ToBase64String(Encoding.UTF8.GetBytes(message.Receiver));
            message.Sender = Convert.ToBase64String(Encoding.UTF8.GetBytes(message.Sender));
            _chatClient.SendMessage(message);
        }
    }
}
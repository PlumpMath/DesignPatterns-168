using System;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class EncryptedChatClientDecorator : IChatClient
    {
        private readonly IChatClient _chatClient;

        public EncryptedChatClientDecorator(IChatClient chatClient)
        {
            _chatClient = chatClient;
        }

        public void SendMessage(Message message)
        {
            message.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(message.Text));
            _chatClient.SendMessage(message);
        }

        public void ReceiveMessage(Message message)
        {
            message.Text = Encoding.UTF8.GetString(Convert.FromBase64String(message.Text));
            _chatClient.ReceiveMessage(message);
        }
    }
}
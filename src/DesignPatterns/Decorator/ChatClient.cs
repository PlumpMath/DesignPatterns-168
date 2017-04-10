using System;

namespace DesignPatterns.Decorator
{
    public class ChatClient : IChatClient
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine($"Message {message.Text} was sent from {message.Sender} to {message.Receiver}");
        }

        public void ReceiveMessage(Message message)
        {
            Console.WriteLine($"Message {message.Text} was received by {message.Receiver} from {message.Sender}");
        }
    }
}

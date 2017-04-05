using System;
using System.Linq;

namespace DesignPatterns.Builder
{
    public class BuilderExample
    {
        private static void PrintMessage(Email email)
        {
            Console.WriteLine($"Email from {email.SenderName}");
            Console.WriteLine($"on subject {email.Subject}");
            Console.WriteLine($"with recipients: {string.Join(" ", email.Recipients)}");
            Console.WriteLine($"email text: {email.Body}");
            Console.WriteLine();
        }

        public static void Introduce()
        {
            var builder = new EmailBuilder();
            var message = builder
                .AddRecipient("Kernighan")
                .SetBody("tmp text")
                .SetSender("Ritchie")
                .SetSubject("On C programming language")
                .SetBody("Hello, would you like to code UNIX in C?")
                .GetResult();
            PrintMessage(message);

            var answer = builder
                .SetBody("I'd love to do it!")
                .AddRecipient("Ritchie")
                .SetSender("Kernighan")
                .SetSubject("RE: On C programming language")
                .GetResult();
            PrintMessage(answer);
        }
    }
}

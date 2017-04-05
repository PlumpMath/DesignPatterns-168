namespace DesignPatterns.Builder
{
    public interface IEmptyEmailBuilder
    {
        IEmailWithBodyBuilder SetBody(string newBody);
        IEmailWithRecipientBuilder AddRecipient(string recipientName);
    }
}
namespace DesignPatterns.Builder
{
    public interface IEmailWithBodyBuilder
    {
        ICompleteEmailBuilder AddRecipient(string recipientName);
    }
}
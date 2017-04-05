namespace DesignPatterns.Builder
{
    public interface ICompleteEmailBuilder : IEmailWithBodyBuilder, IEmailWithRecipientBuilder
    {
        ICompleteEmailBuilder SetSubject(string subject);
        ICompleteEmailBuilder SetSender(string sender);
        Email GetResult();
    }
}
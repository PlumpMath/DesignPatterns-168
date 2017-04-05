namespace DesignPatterns.Builder
{
    public interface IEmailWithRecipientBuilder
    {
        ICompleteEmailBuilder SetBody(string newBody);
    }
}
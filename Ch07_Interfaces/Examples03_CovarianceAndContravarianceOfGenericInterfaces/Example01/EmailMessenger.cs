namespace Example01
{
    internal class EmailMessenger : IMessenger<EmailMessage>
    {
        public EmailMessage WriteMessage(string text)
        {
            return new EmailMessage($"Email: {text}");
        }
    }
}

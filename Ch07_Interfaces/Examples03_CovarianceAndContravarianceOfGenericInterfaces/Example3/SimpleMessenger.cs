namespace Example03
{
    internal class SimpleMessenger : IMessenger<Message, EmailMessage>
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }

        public EmailMessage WriteMessage(string text)
        {
            return new EmailMessage($"Email: {text}");
        }
    }
}

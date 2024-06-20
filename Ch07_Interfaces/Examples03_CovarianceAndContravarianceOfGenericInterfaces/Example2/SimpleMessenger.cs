namespace Example02
{
    internal class SimpleMessenger : IMessenger<Message>
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }
    }
}

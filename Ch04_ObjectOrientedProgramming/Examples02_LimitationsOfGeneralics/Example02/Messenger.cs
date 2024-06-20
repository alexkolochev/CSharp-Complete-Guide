namespace Example02
{
    internal class Messenger<T> where T : Message
    {
        public void SendMessage(T message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }
    }
}

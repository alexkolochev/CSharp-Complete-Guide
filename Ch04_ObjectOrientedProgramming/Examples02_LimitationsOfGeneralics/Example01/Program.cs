// Ограничения методов
using Example01;

SendMessage(new Message("Hello, World!"));
SendMessage(new EmailMessage("Bye, World!"));

void SendMessage<T>(T message) where T : Message
{
    Console.WriteLine($"Отправляется сообщение: {message.Text}");
}

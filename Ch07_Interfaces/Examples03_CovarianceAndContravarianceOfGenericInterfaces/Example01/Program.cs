// Ковариантные интерфейсы
using Example01;

IMessenger<Message> outlook = new EmailMessenger();
Message message = outlook.WriteMessage("Hello World");
Console.WriteLine(message.Text);

IMessenger<EmailMessage> emailClient = new EmailMessenger();
IMessenger<Message> messenger = emailClient;
Message emailMessage = messenger.WriteMessage("Hi!");
Console.WriteLine(emailMessage.Text);

// Ограничения обобщений в типах
using Example02;

Messenger<Message> telegram = new Messenger<Message>();
telegram.SendMessage(new Message("Hello, World!"));

Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
outlook.SendMessage(new EmailMessage("Bye, World!"));

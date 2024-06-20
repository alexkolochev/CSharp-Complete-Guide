// Контрвариантные интерфейсы
using Example02;

IMessenger<EmailMessage> outlook = new SimpleMessenger();
outlook.SendMessage(new EmailMessage("Hi!"));

IMessenger<Message> telegram = new SimpleMessenger();
IMessenger<EmailMessage> emailClient = telegram;
emailClient.SendMessage(new EmailMessage("Hello"));

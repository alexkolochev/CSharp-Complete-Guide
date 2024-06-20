// Совмещение ковариантности и контрвариантности
using Example03;

IMessenger<EmailMessage, Message> messenger = new SimpleMessenger();
Message message = messenger.WriteMessage("Hello, World!");
Console.WriteLine(message.Text);
messenger.SendMessage(new EmailMessage("Test"));

IMessenger<EmailMessage, EmailMessage> outlook = new SimpleMessenger();
EmailMessage emailMessage = outlook.WriteMessage("Message from Outlook");
outlook.SendMessage(emailMessage);

IMessenger<Message, Message> telegram = new SimpleMessenger();
Message simpleMessage = telegram.WriteMessage("Message from Telegram");
telegram.SendMessage(simpleMessage);

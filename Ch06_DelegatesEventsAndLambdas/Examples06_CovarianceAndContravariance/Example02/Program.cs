// Ковариантность и контравариантность в обобщенных делегатах
using Example02;

#region Ковариантность
/*
// возвращает EmailMessage - более конкретный тип
MessageBuilder<EmailMessage> EmailMessageWriter = (string text) => new EmailMessage(text);

// возвращает более общий тип Message
MessageBuilder<Message> messageBuilder = EmailMessageWriter; // ковариантность
Message message = messageBuilder("Hello, Tom");
message.Print();

delegate T MessageBuilder<out T>(string text);
*/
#endregion

#region Контрвариантность
/*
// принимает объект более общего типа
MessageReceiver<Message> messageReceiver = (Message message) => message.Print();

// принимает объект более конкретного типа
MessageReceiver<EmailMessage> emailMessageReceiver = messageReceiver; // контрвариантность

messageReceiver(new Message("Hello, World!"));
messageReceiver(new EmailMessage("Hello, World!"));

delegate void MessageReceiver<in T>(T message);
*/
#endregion

#region Совмещение ковариантности и контрвариантности
MessageConverter<Message, EmailMessage> toEmailConverter = (Message message) => new EmailMessage(message.Text);

MessageConverter<SmsMessage, Message> converter = toEmailConverter;
Message message = converter(new SmsMessage("Hello, World!"));
message.Print();

delegate E MessageConverter<in M, out E>(M message);
#endregion

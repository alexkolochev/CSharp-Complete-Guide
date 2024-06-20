using Example01;

#region Ковариантность
/*
// делегату с базовым типом передаем метод с производным типом
MessageBuilder messageBuilder = WriteEmailMessage; // ковариантность
Message message = messageBuilder("Hello");
message.Print();

EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);

delegate Message MessageBuilder(string text);
*/
#endregion

#region Контравариантность
// делегату с производным типом передаем метод с базовым типом
EmailReceiver emailBox = ReceiveMessage; // контрвариантность
emailBox(new EmailMessage("Welcome"));

void ReceiveMessage(Message message) => message.Print();

delegate void EmailReceiver(EmailMessage message);
#endregion

// Определение и вызов событий
// Добавление обработчика события
// Добавление и удаление обработчиков
// Управление обработчиками
// Передача данных события
using Example01;

Account account = new Account(100);
account.Notify += DisplayMessage; // добавляем обработчик DisplayMessage
account.Notify += DisplayRedMessage; // добавляем обработчик DisplayRedMessage
account.Put(20);
account.Notify -= DisplayRedMessage;
account.Take(50);

void DisplayMessage(Account sender, AccountEventArgs e)
{
    Console.WriteLine($"Сумма транзакции: {e.Sum}");
    Console.WriteLine(e.Message);
    Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
}

void DisplayRedMessage(Account sender, AccountEventArgs e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Сумма транзакции: {e.Sum}");
    Console.WriteLine(e.Message);
    Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
    Console.ResetColor();
}

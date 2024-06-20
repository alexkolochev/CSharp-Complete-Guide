// Вызов методов
// Получение результата
using Example06;

var myPrinter = new Printer();
var createMessage = typeof(Printer).GetMethod("CreateMessage");
var result = createMessage?.Invoke(myPrinter, null);
Console.WriteLine(result);

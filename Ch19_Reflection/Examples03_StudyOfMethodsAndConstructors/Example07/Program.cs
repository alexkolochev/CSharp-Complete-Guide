// Вызов методов
// Передача параметров
using Example07;

var myPrinter = new Printer();
var printMessage = typeof(Printer).GetMethod("PrintMessage");
printMessage?.Invoke(myPrinter, ["Hi, World!", 3]);

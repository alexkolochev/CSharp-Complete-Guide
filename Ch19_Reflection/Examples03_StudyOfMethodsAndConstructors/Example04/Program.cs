// Вызов методов
// Вызов метода
using Example04;

var myPrinter = new Printer("Hello");
var print = typeof(Printer).GetMethod("Print");
print?.Invoke(myPrinter, null);

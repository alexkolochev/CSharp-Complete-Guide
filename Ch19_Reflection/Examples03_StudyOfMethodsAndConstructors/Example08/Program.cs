// Вызов методов
// Вызов обобщенного метода
using Example08;

var myPrinter = new Printer();
var printValue = typeof(Printer).GetMethod("PrintValue");
var printStringValue = printValue?.MakeGenericMethod(typeof(string));
printStringValue?.Invoke(myPrinter, ["Hello, World!"]);

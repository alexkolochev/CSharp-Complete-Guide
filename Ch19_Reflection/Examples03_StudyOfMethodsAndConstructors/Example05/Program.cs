// Вызов методов
// Вызов непубличного метода
using Example05;
using System.Reflection;

var myPrinter = new Printer("Hello, METANIT.COM");
var print = typeof(Printer).GetMethod("Print",
            BindingFlags.Instance |
            BindingFlags.Public |
            BindingFlags.NonPublic);
print?.Invoke(myPrinter, parameters: null);

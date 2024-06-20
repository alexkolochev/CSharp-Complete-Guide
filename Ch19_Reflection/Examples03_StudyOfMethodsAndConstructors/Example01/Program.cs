// Получение информации о методах
using Example01;

Type myType = typeof(Printer);

Console.WriteLine("Методы:");
foreach (var method in myType.GetMethods())
{
    string modificator = string.Empty;

    if (method.IsStatic)
        modificator += "static ";

    if (method.IsVirtual)
        modificator += "virtual ";

    Console.WriteLine($"{modificator}{method.ReturnType.Name} {method.Name} ()");
}

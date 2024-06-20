// Поиск реализованных интерфейсов
using Example02;

Type myType = typeof(Person);

Console.WriteLine("Реализованные интерфейсы:");
foreach (var i in myType.GetInterfaces())
    Console.WriteLine(i.Name);

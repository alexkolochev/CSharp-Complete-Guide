// Статические поля обобщенных классов
using Example02;

Person<int> tom = new Person<int>(546, "Tom");
Person<int>.code = 1124;

Person<string> bob = new Person<string>("abc", "Bob");
Person<string>.code = "meta";

Console.WriteLine(Person<int>.code);
Console.WriteLine(Person<string>.code);

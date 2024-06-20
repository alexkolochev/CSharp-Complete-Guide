// Использование нескольких универсальных параметров
using Example03;

Person<int, string> tom = new Person<int, string>(546, "qwerty", "Tom");
Console.WriteLine(tom.Id);
Console.WriteLine(tom.Password);

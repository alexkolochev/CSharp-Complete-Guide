// Деконструкторы
using Example02;

Person person = new Person("Tom", 33);
(string name, int age) = person;
Console.WriteLine(name);
Console.WriteLine(age);

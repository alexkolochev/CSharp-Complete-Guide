// Поверхностное копирование
using Example01;

var tom = new Person("Tom", 23);
var bob = (Person)tom.Clone();
bob.Name = "Bob";
Console.WriteLine(tom.Name);
Console.WriteLine(bob.Name);

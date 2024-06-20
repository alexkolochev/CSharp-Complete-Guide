// Глубокое копирование
using Example02;

var tom = new Person("Tom", 23, new Company("Microsoft"));
var bob = (Person)tom.Clone();
bob.Work.Name = "Google";
Console.WriteLine(tom.Work.Name);
Console.WriteLine(bob.Work.Name);

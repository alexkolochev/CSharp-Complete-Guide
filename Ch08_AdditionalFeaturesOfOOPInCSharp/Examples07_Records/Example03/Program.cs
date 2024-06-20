// Оператор with
using Example03;

var tom = new Person("Tom", 37);
var sam = tom with { Name = "Sam" };
Console.WriteLine($"{sam.Name} - {sam.Age}");

var person1 = new Person("Tom", 37);
var person2 = person1 with { };

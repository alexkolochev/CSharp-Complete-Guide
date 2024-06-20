// Сортировка сложных объектов
using Example02;

var people = new List<Person>
{
    new("Tom", 37),
    new("Sam", 28),
    new("Tom", 22),
    new("Bob", 41),
};

//var sortedPeople = from p in people
//                    orderby p.Name
//                    select p;
var sortedPeople = people.OrderBy(p => p.Name);

foreach (var p in sortedPeople)
    Console.WriteLine($"{p.Name} - {p.Age}");

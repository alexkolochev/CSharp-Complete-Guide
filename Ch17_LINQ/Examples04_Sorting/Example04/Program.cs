// Множественные критерии сортировки
using Example04;

var people = new List<Person>
{
    new("Tom", 37),
    new("Sam", 28),
    new("Tom", 22),
    new("Bob", 41),
};

var sortedPeople1 = from p in people
                    orderby p.Name, p.Age
                    select p;

foreach (var person in sortedPeople1)
    Console.WriteLine($"{person.Name} - {person.Age}");

//var sortedPeople = from p in people
//                   orderby p.Name, p.Age descending
//                   select p;
var sortedPeople = people.OrderBy(p => p.Name).ThenByDescending(p => p.Age);

foreach (var person in sortedPeople)
    Console.WriteLine($"{person.Name} - {person.Age}");

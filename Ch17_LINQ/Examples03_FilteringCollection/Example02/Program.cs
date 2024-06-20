// Выборка сложных объектов
using Example02;

var people = new List<Person>
{
    new("Tom", 23, ["english", "german"]),
    new("Bob", 27, ["english", "french"]),
    new("Sam", 29, ["english", "spanish"]),
    new("Alice", 24, ["spanish", "german"])
};

//var selectedPeople = from p in people
//                     where p.Age > 25
//                     select p;
var selectedPeople = people.Where(p => p.Age > 25);

foreach (var person in selectedPeople)
    Console.WriteLine($"{person.Name} - {person.Age}");

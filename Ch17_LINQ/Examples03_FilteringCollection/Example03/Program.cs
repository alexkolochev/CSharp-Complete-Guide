// Сложные фильтры
using Example03;

var people = new List<Person>
{
    new("Tom", 23, ["english", "german"]),
    new("Bob", 27, ["english", "french"]),
    new("Sam", 29, ["english", "spanish"]),
    new("Alice", 24, ["spanish", "german"])
};

//var selectedPeople = from person in people
//                     from lang in person.Languages
//                     where person.Age < 28
//                     where lang == "english"
//                     select person;
var selectedPeople = people.SelectMany(u => u.Languages, (u, l) => new { Person = u, Lang = l })
    .Where(u => u.Lang == "english" && u.Person.Age < 28)
    .Select(u => u.Person);

foreach (var person in selectedPeople)
    Console.WriteLine($"{person.Name} - {person.Age}");
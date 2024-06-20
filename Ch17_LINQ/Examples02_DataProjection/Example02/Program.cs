// Переменые в запросах и оператор let
using Example02;

var people = new List<Person>
{
    new("Tom", 23),
    new("Bob", 27)
};

var personel = from p in people
               let name = $"Mr. {p.Name}"
               let year = DateTime.Now.Year - p.Age
               select new
               {
                   Name = name,
                   Year = year
               };

foreach (var person in personel)
    Console.WriteLine($"{person.Name} - {person.Year}");

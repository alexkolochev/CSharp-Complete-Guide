using Example01;

var people = new List<Person>
{
    new("Tom", 23),
    new("Bob", 27),
    new("Sam", 29),
    new("Alice", 24)
};

//var names = from p in people select p.Name;
var names = people.Select(p => p.Name);

foreach (var name in names)
    Console.WriteLine(name);

//var personel = from p in people
//               select new
//               {
//                   FirstName = p.Name,
//                   Year = DateTime.Now.Year - p.Age
//               };
var personel = people.Select(p => new
{
    FirstName = p.Name,
    Year = DateTime.Now.Year - p.Age
});

foreach (var person in personel)
    Console.WriteLine($"{person.FirstName} - {person.Year}");

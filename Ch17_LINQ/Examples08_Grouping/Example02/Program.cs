// Создание нового объекта при группировке
using Example02;

Person[] people =
[
    new("Tom", "Microsoft"), new("Sam", "Google"),
    new("Bob", "JetBrains"), new("Mike", "Microsoft"),
    new("Kate", "JetBrains"), new("Alice", "Microsoft"),
];

//var companies = from person in people
//                group person by person.Company into g
//                select new { Name = g.Key, Count = g.Count() };
var companies = people.GroupBy(p => p.Company).Select(g => new { Name = g.Key, Count = g.Count() });

foreach (var company in companies)
    Console.WriteLine($"{company.Name} : {company.Count}");

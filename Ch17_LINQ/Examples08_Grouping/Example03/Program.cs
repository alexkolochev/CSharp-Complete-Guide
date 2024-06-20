// Вложенные запросы
using Example03;

Person[] people =
[
    new("Tom", "Microsoft"), new("Sam", "Google"),
    new("Bob", "JetBrains"), new("Mike", "Microsoft"),
    new("Kate", "JetBrains"), new("Alice", "Microsoft"),
];

var companies = from person in people
                group person by person.Company into g
                select new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Employees = from p in g select p
                };

foreach (var company in companies)
{
    Console.WriteLine($"{company.Name} : {company.Count}");

    foreach (var employee in company.Employees)
    {
        Console.WriteLine(employee.Name);
    }
    Console.WriteLine();
}

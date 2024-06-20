// GroupJoin
using Example02;

Person[] people =
[
    new("Tom", "Microsoft"), new("Sam", "Google"),
    new("Bob", "JetBrains"), new("Mike", "Microsoft"),
];
Company[] companies =
[
    new("Microsoft", "C#"),
    new("Google", "Go"),
    new("Oracle", "Java")
];

//var personnel = companies.GroupJoin(people,
//    c => c.Title,
//    p => p.Company,
//    (c, employees) => new { c.Title, Employees = employees });
var personnel = from c in companies
                join p in people on c.Title equals p.Company into g
                select new { c.Title, Employees = g };

foreach (var company in personnel)
{
    Console.WriteLine(company.Title);
    foreach (var employee in company.Employees)
    {
        Console.WriteLine(employee.Name);
    }
    Console.WriteLine();
}

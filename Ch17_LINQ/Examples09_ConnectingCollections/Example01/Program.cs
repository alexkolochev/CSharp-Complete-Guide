// Join
using Example01;

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

//var employees = from p in people
//                join c in companies on p.Company equals c.Title
//                select new { p.Name, Company = c.Title, c.Language };
var employees = people.Join(companies, // второй набор
    p => p.Company, // свойство-селектор объекта из первого набора
    c => c.Title, // свойство-селектор объекта из второго набора
    (p, c) => new { p.Name, Company = c.Title, c.Language }); // результат

foreach (var employee in employees)
    Console.WriteLine($"{employee.Name} - {employee.Company} ({employee.Language})");

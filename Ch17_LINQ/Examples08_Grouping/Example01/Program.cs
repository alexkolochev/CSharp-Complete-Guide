// Оператор group by и метод GroupBy
using Example01;

Person[] people =
[
    new("Tom", "Microsoft"), new("Sam", "Google"),
    new("Bob", "JetBrains"), new("Mike", "Microsoft"),
    new("Kate", "JetBrains"), new("Alice", "Microsoft"),
];

//var companies = from person in people
//                group person by person.Company;
var companies = people.GroupBy(p => p.Company);

foreach (var company in companies)
{
    Console.WriteLine(company.Key);

    foreach (var person in company)
    {
        Console.WriteLine(person.Name);
    }
    Console.WriteLine();
}

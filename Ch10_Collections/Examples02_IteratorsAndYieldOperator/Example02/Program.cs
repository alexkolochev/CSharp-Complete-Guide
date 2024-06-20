// Именованный итератор
using Example02;

var people = new Person[]
{
    new("Tom"),
    new("Bob"),
    new("Sam")
};
var microsoft = new Company(people);

foreach (Person employee in microsoft.GetPersonnel(5))
{
    Console.WriteLine(employee.Name);
}

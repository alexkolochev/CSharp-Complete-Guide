// Позиционные records
using Example05;

var person = new Person("Tom", 37) { Company = "Google" };
Console.WriteLine(person);
var (name, age) = person;
Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(person.Company);
person.Company = "Microsoft";
Console.WriteLine(person.Company);

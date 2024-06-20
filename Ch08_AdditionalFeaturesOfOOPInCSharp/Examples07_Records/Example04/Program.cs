// Позиционные records
using Example04;

var person = new Person("Tom", 37);
Console.WriteLine(person);

var (personName, personAge) = person;

Console.WriteLine(personAge);
Console.WriteLine(personName);

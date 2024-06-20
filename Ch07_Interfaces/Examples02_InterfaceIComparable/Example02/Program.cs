// Применение компаратора
using Example02;

var alice = new Person("Alice", 41);
var tom = new Person("Tom", 37);
var kate = new Person("Kate", 25);

Person[] people = [alice, tom, kate];
Array.Sort(people, new PeopleComparer());

foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}

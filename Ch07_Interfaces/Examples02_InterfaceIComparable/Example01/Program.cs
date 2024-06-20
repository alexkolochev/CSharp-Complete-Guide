using Example01;

var tom = new Person("Tom", 37);
var bob = new Person("Bob", 41);
var sam = new Person("Sam", 25);

Person[] people = [tom, bob, sam];
Array.Sort(people);

foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}

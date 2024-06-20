// Работа со сложными объектами
using Example05;

Person[] students = [new("Tom"), new("Bob"), new("Sam")];
Person[] employees = [new("Tom"), new("Bob"), new("Mike")];

var people = students.Union(employees);

foreach (Person person in people)
    Console.WriteLine(person.Name);

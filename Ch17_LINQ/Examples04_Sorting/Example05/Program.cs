// Переопределение критерия сортировки
using Example05;

string[] people = ["Kate", "Tom", "Sam", "Mike", "Alice"];
var sortedPeople = people.OrderBy(p => p, new CustomStringComparer());

foreach (var person in sortedPeople)
    Console.WriteLine(person);

string[] people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };

//var selectedPeople = people.Where(p => p.Length == 3);
var selectedPeople = from p in people
                     where p.Length == 3
                     select p;

foreach (var person in selectedPeople)
    Console.WriteLine(person);

int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
var evens1 = numbers.Where(i => i % 2 == 0 && i > 10);
var evens2 = from i in numbers
             where i % 2 == 0 && i > 10
             select i;

foreach (var i in evens1)
    Console.WriteLine(i);

foreach (var i in evens2)
    Console.WriteLine(i);

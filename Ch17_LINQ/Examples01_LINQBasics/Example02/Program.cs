// Методы расширения LINQ
string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

var selectedPeople = people.Where(p => p.ToUpper().StartsWith('T')).OrderBy(p => p);

foreach (var person in selectedPeople)
    Console.WriteLine(person);

int number = (from p in people where p.ToUpper().StartsWith('T') select p).Count();
Console.WriteLine(number);

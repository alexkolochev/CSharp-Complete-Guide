// Постраничный вывод
string[] people = ["Tom", "Sam", "Mike", "Kate", "Bob", "Alice"];

var result = people.Skip(3).Take(2);

foreach (var person in result)
    Console.WriteLine(person);

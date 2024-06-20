// Skip
string[] people = ["Tom", "Sam", "Bob", "Mike", "Kate"];

var result1 = people.Skip(2);
foreach (var person in result1)
    Console.WriteLine(person);

var result2 = people.SkipLast(2);
foreach (var person in result2)
    Console.WriteLine(person);

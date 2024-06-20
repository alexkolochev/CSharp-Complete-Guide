// Take
string[] people = ["Tom", "Sam", "Mike", "Kate", "Bob"];

var result1 = people.Take(3);
foreach (var person in result1)
    Console.WriteLine(person);

var result2 = people.TakeLast(3);
foreach (var person in result2)
    Console.WriteLine(person);
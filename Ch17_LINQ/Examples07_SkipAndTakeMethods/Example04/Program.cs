// TakeWhile
string[] people = ["Tom", "Sam", "Mike", "Kate", "Bob"];

var result = people.TakeWhile(p => p.Length == 3);

foreach (var person in result)
    Console.WriteLine(person);

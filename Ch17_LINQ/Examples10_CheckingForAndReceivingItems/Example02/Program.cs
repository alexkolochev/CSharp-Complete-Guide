// Contains
using Example02;

Person[] people = [new("Tom"), new("Sam"), new("Bob")];
var tom = new Person("Tom");
var mike = new Person("Mike");

bool hasTom = people.Contains(tom);
Console.WriteLine(hasTom);

bool hasMike = people.Contains(mike);
Console.WriteLine(hasMike);

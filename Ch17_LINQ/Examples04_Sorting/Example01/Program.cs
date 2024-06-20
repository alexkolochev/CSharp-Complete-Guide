// Оператор orderby и метод OrderBy
int[] numbers = [3, 12, 4, 10];

//var orderedNumbers = from i in numbers
//                     orderby i
//                     select i;
var orderedNumbers = numbers.OrderBy(i => i);

foreach (var i in orderedNumbers)
    Console.WriteLine(i);

string[] people = ["Tom", "Bob", "Sam"];

//var orderedPeople = from p in people
//                    orderby p
//                    select p;
var orderedPeople = people.OrderBy(p => p);

foreach (var person in orderedPeople)
    Console.WriteLine(person);

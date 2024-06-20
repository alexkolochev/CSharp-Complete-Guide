// First/FirstOrDefault
string[] people = ["Tom", "Bob", "Kate", "Tim", "Mike", "Sam"];

var firstWith4Chars = people.First(s => s.Length == 4);
Console.WriteLine(firstWith4Chars);

//var firstWith5Chars = people.First(s => s.Length == 5);  // ! исключение
//Console.WriteLine(firstWith5Chars);

//var first = new string[] { }.First();  // ! исключение
//Console.WriteLine(first);

var first = people.FirstOrDefault();
Console.WriteLine(first);

firstWith4Chars = people.FirstOrDefault(s => s.Length == 4);
Console.WriteLine(firstWith4Chars);

var firstOrDefault1 = new string[] { }.FirstOrDefault();
Console.WriteLine(firstOrDefault1);

string? firstWith5Chars = people.FirstOrDefault(s => s.Length == 5, "Undefined");
Console.WriteLine(firstWith5Chars);

string? firstOrDefault2 = new string[] { }.FirstOrDefault("hello");
Console.WriteLine(firstOrDefault2);

int firstNumber = new int[] { }.FirstOrDefault(100);
Console.WriteLine(firstNumber);


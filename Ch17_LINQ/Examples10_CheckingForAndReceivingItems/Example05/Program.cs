// Last и LastOrDefault
string[] people = ["Tom", "Bob", "Kate", "Tim", "Mike", "Sam"];

string last1 = people.Last();
Console.WriteLine(last1);

string lastWith4Chars1 = people.Last(s => s.Length == 4);
Console.WriteLine(lastWith4Chars1);

string? last2 = people.LastOrDefault();
Console.WriteLine(last2);

string? lastWith4Chars2 = people.LastOrDefault(s => s.Length == 4);
Console.WriteLine(lastWith4Chars2);

string? lastWith5Chars = people.LastOrDefault(s => s.Length == 5);
Console.WriteLine(lastWith5Chars);

string? lastWith5CharsOrDefault = people.LastOrDefault(s => s.Length == 5, "Undefined");
Console.WriteLine(lastWith5CharsOrDefault);

string? lastOrDefault = new string[] { }.LastOrDefault("hello");
Console.WriteLine(lastOrDefault);

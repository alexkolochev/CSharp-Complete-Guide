string[] people = ["Tom", "Tim", "Bob", "Sam"];

// All
bool allHas3Chars = people.All(s => s.Length == 3);
Console.WriteLine(allHas3Chars);

bool allStartsWithT = people.All(s => s.StartsWith('T'));
Console.WriteLine(allStartsWithT);

// Any
bool anyHasMore3Chars = people.Any(s => s.Length > 3);
Console.WriteLine(anyHasMore3Chars);

bool anyStartsWithT = people.Any(s => s.StartsWith('T'));
Console.WriteLine(anyStartsWithT);

// Contains
bool hasTom = people.Contains("Tom");
Console.WriteLine(hasTom);

bool hasMike = people.Contains("Mike");
Console.WriteLine(hasMike);

// First
var first = people.First();
Console.WriteLine(first);
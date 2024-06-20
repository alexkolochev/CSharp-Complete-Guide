// Contains
using Example03;

string[] people = ["tom", "Tim", "bOb", "Sam"];
bool hasTom = people.Contains("Tom", new CustomStringComparer());
//bool hasTom = people.Contains("Tom", StringComparer.OrdinalIgnoreCase);
Console.WriteLine(hasTom);

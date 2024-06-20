// Замена и метод Replace
using System.Text.RegularExpressions;

string text = "Мама  мыла  раму. ";
string pattern = @"\s+";
string target = " ";
Regex regex = new Regex(pattern);
string result = regex.Replace(text, target);
Console.WriteLine(result);

string phoneNumber = "+1(876)-234-12-98";
pattern = @"\D";
target = string.Empty;
regex = new Regex(pattern);
result = regex.Replace(phoneNumber, target);
Console.WriteLine(result);

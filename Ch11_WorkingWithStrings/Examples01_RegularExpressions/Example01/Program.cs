using System.Text.RegularExpressions;

string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
Regex regex = new Regex(@"туп(\w*)");
MatchCollection mathes = regex.Matches(s);

if (mathes.Count > 0)
{
	foreach (Match match in mathes)
	{
        Console.WriteLine(match.Value);
    }
}
else
{
    Console.WriteLine("Совпадений не найдено");
}

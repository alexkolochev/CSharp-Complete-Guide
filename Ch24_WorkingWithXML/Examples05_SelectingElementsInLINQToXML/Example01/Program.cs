using System.Xml.Linq;

XDocument xDoc = XDocument.Load("people.xml");
XElement? people = xDoc.Element("people");

if (people is not null)
{
    foreach (XElement person in people.Elements("person"))
    {
        XAttribute? name = person.Attribute("name");
        XElement? company = person.Element("company");
        XElement? age = person.Element("age");

        Console.WriteLine($"Person: {name?.Value}");
        Console.WriteLine($"Company: {company?.Value}");
        Console.WriteLine($"Age: {age?.Value}");

        Console.WriteLine();
    }
}

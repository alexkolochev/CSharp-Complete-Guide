using System.Xml.Linq;

XDocument xDoc = XDocument.Load("people.xml");

var microsoft = xDoc.Element("people")?
    .Elements("person")
    .Where(p => p.Element("company")?.Value == "Microsoft")
    .Select(p => new
    {
        name = p.Attribute("name")?.Value,
        age = p.Element("age")?.Value,
        company = p.Element("company")?.Value
    });

if (microsoft is not null)
{
    foreach (var person in microsoft)
        Console.WriteLine($"Name: {person.name}; Age: {person.age}");
}

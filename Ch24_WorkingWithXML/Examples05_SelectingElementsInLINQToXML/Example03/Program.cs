using System.Xml.Linq;

XDocument xDoc = XDocument.Load("people.xml");

var tom = xDoc.Element("people")?
    .Elements("person")
    .FirstOrDefault(p => p.Attribute("name")?.Value == "Tom");

var name = tom?.Attribute("name")?.Value;
var age = tom?.Element("age")?.Value;
var company = tom?.Element("company")?.Value;

Console.WriteLine($"Name: {name}; Age: {age}; Company: {company}");

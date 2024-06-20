// Аналог Example01
using System.Xml.Linq;

XDocument xDoc = new XDocument(new XElement("people",
    new XElement("person",
        new XAttribute("name", "Tom"),
        new XElement("company", "Microsoft"),
        new XElement("age", 37)),
    new XElement("person",
        new XAttribute("name", "Bob"),
        new XElement("company", "Google"),
        new XElement("age", 41))));
xDoc.Save("people.xml");

Console.WriteLine("Date saved");

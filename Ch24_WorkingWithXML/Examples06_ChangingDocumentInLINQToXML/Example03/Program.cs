// Удаление данных
using System.Xml.Linq;

XDocument xDoc = XDocument.Load("people.xml");
XElement? xRoot = xDoc.Element("people");

if (xRoot is not null)
{
    var bob = xRoot.Elements("person")
        .FirstOrDefault(p => p.Attribute("name")?.Value == "Bob");

    if (bob is not null)
    {
        bob.Remove();
        xDoc.Save("people.xml");
    }
}

Console.WriteLine(xDoc);

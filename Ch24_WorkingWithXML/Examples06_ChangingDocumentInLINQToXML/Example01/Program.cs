// Добавление данных
using System.Xml.Linq;

XDocument xDoc = XDocument.Load("people.xml");
XElement? xRoot = xDoc.Element("people");

if (xRoot is not null)
{
    xRoot.Add(new XElement("person",
        new XAttribute("name", "Sam"),
        new XElement("company", "JetBrains"),
        new XElement("age", 28)));
    xDoc.Save("people.xml");
}

Console.WriteLine(xDoc);

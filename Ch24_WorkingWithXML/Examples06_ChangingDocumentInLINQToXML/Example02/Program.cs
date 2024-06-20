// Изменение данных
using System.Xml.Linq;

XDocument xDoc = XDocument.Load("people.xml");

var tom = xDoc.Element("people")?
    .Elements("person")?
    .FirstOrDefault(p => p.Attribute("name")?.Value == "Tom");

if (tom is not null)
{
    var name = tom.Attribute("name");
    if (name is not null) name.Value = "Tomas";

    var age = tom.Element("age");
    if (age is not null) age.Value = "22";

    xDoc.Save("people.xml");
}

Console.WriteLine(xDoc);

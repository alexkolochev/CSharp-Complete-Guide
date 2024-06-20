using Example01;
using System.Xml;

var people = new List<Person>();

XmlDocument xDoc = new();
xDoc.Load("people.xml");

XmlElement? xRoot = xDoc.DocumentElement; // получим корневой элемент

if (xRoot != null)
{
    // обход всех узлов в корневом элементе
    foreach (XmlElement xNode in xRoot)
    {
        Person person = new Person();

        // получаем атрибут name
        XmlNode? attr = xNode.Attributes.GetNamedItem("name");
        person.Name = attr?.Value;

        // обходим все дочерние узлы элемента user
        foreach (XmlNode childNode in xNode.ChildNodes)
        {
            if (childNode.Name == "company")
            {
                person.Company = childNode.InnerText;
            }
            
            if (childNode.Name == "age")
            {
                person.Age = int.Parse(childNode.InnerText);
            }
        }
        people.Add(person);
    }

    foreach (var person in people)
        Console.WriteLine($"{person.Name} ({person.Company}) - {person.Age}");
}

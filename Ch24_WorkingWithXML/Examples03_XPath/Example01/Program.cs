using System.Xml;

XmlDocument xDoc = new();
xDoc.Load("people.xml");
XmlElement? xRoot = xDoc.DocumentElement;

// Выбор всех дочерних узлов
XmlNodeList? nodes = xRoot?.SelectNodes("*");
if (nodes is not null)
{
    foreach (XmlNode node in nodes)
        Console.WriteLine(node.OuterXml);
}

// Значения атрибутов name у элементов person
XmlNodeList? personNodes = xRoot?.SelectNodes("person");
if (personNodes is not null)
{
    foreach (XmlNode node in personNodes)
    {
        Console.WriteLine(node.SelectSingleNode("@name")?.Value);
    }
}

// Выберем узел, у которого атрибут name имеет значение "Tom"
XmlNode? tomNode = xRoot?.SelectSingleNode("person[@name='Tom']");
Console.WriteLine(tomNode?.OuterXml);

// Получение компаний. Для этого надо осуществить выборку вниз по иерархии элементов
XmlNodeList? companyNodes = xRoot?.SelectNodes("//person/company");
if (companyNodes is not null)
{
    foreach(XmlNode node in companyNodes)
        Console.WriteLine(node.InnerText);
}

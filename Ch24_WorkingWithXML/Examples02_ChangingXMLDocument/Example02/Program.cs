// Удаление узлов
using System.Xml;

XmlDocument xDoc = new();
xDoc.Load("people.xml");
XmlElement? xRoot = xDoc.DocumentElement;
XmlNode? firstNode = xRoot?.FirstChild;
if (firstNode is not null) xRoot?.RemoveChild(firstNode);
xDoc.Save("people.xml");

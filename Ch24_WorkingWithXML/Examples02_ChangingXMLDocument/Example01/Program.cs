using System.Xml;

XmlDocument xDoc = new();
xDoc.Load("people.xml");
XmlElement? xRoot = xDoc.DocumentElement;

// создаем новый элемент person
XmlElement personElem = xDoc.CreateElement("person");

// создаем атрибут name
XmlAttribute nameAttr = xDoc.CreateAttribute("name");

// создаем элементы company и age
XmlElement companyElem = xDoc.CreateElement("company");
XmlElement ageElem = xDoc.CreateElement("age");

// создаем текстовые значения для элементов и атрибута
XmlText nameText = xDoc.CreateTextNode("Mark");
XmlText companyText = xDoc.CreateTextNode("Facebook");
XmlText ageText = xDoc.CreateTextNode("30");

// добавляем узлы
nameAttr.AppendChild(nameText);
companyElem.AppendChild(companyText);
ageElem.AppendChild(ageText);

// добавляем атрибут name
personElem.Attributes.Append(nameAttr);

// добавляем элементы company и age
personElem.AppendChild(companyElem);
personElem.AppendChild(ageElem);

// добавляем в корневой элемент новый элемент person
xRoot?.AppendChild(personElem);

// сохраняем изменения xml-документа в файл
xDoc.Save("people.xml");

using System.Xml.Linq;

XDocument xDoc = new();

XElement tom = new("person");
XAttribute tomNameAttr = new("name", "Tom");
XElement tomCompanyElem = new("company", "Microsoft");
XElement tomAgeElem = new("age", "37");
tom.Add(tomNameAttr);
tom.Add(tomCompanyElem);
tom.Add(tomAgeElem);

XElement bob = new("person");
XAttribute bobNameAttr = new("name", "Bob");
XElement bobCompanyElem = new("company", "Google");
XElement bobAgeElem = new("age", "41");
bob.Add(bobNameAttr);
bob.Add(bobCompanyElem);
bob.Add(bobAgeElem);

XElement people = new("people");
people.Add(tom);
people.Add(bob);

xDoc.Add(people);
xDoc.Save("people.xml");

Console.WriteLine("Data saved");

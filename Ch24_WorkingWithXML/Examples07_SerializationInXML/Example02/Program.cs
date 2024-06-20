// Десериализация
using Example02;
using System.Xml.Serialization;

XmlSerializer xmlSerializer = new(typeof(Person));

using (FileStream fs = new("person.xml", FileMode.OpenOrCreate))
{
    Person? person = xmlSerializer.Deserialize(fs) as Person;
    Console.WriteLine($"Name: {person?.Name}; Age: {person?.Age}");
}

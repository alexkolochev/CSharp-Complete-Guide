// Сериализация
using Example01;
using System.Xml.Serialization;

Person person = new("Tom", 37);

XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

using (FileStream fs = new("person.xml", FileMode.OpenOrCreate))
{
    xmlSerializer.Serialize(fs, person);
    Console.WriteLine("Object has been serialized");
}

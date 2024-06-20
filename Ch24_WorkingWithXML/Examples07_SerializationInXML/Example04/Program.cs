// Сериализация и десериализация коллекций. Более сложная структура
using Example04;
using System.Xml.Serialization;

var microsoft = new Company("Microsoft");
var google = new Company("Google");
Person[] people = [new("Tom", 37, microsoft), new("Bob", 41, google)];

XmlSerializer xmlSerializer = new(typeof(Person[]));

using (FileStream fs = new("people.xml", FileMode.OpenOrCreate))
{
    xmlSerializer.Serialize(fs, people);
}

using (FileStream fs = new("people.xml", FileMode.OpenOrCreate))
{
    Person[]? newPeople = xmlSerializer.Deserialize(fs) as Person[];

    if (newPeople is not null)
    {
        foreach (Person person in newPeople)
        {
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Company: {person.Company.Name}");
        }
    }
}

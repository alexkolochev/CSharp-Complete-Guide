// Сериализация и десериализация коллекций
using Example03;
using System.Xml.Serialization;

Person[] people = [new("Tom", 37), new("Bob", 41)];

XmlSerializer formatter = new(typeof(Person[]));
using (FileStream fs = new("people.xml", FileMode.OpenOrCreate))
{
    formatter.Serialize(fs, people);
}

using (FileStream fs = new("people.xml", FileMode.OpenOrCreate))
{
    Person[]? newPeople = formatter.Deserialize(fs) as Person[];

    if (newPeople is not null)
    {
        foreach (Person person in newPeople)
        {
            Console.WriteLine($"Name: {person.Name}; Age: {person.Age}");
        }
    }
}

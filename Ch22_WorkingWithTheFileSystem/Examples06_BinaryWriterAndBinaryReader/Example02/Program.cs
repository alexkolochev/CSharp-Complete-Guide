// BinaryReader
using Example02;

List<Person> people = new();

using (BinaryReader reader = new(File.Open("people.dat", FileMode.Open)))
{
	while (reader.PeekChar() > -1)
	{
		string name = reader.ReadString();
		int age = reader.ReadInt32();
		people.Add(new Person(name, age));
	}
}

foreach (Person person in people)
    Console.WriteLine($"Name: {person.Name}  Age: {person.Age}");

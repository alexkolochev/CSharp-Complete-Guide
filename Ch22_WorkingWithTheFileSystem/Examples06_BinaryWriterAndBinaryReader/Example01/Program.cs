// BinaryWriter
using Example01;

string path = "people.dat";

Person[] people = [new("Tom", 37), new("Bob", 41)];

using (BinaryWriter writer = new(File.Open(path, FileMode.OpenOrCreate)))
{
	foreach (var person in people)
	{
		writer.Write(person.Name);
		writer.Write(person.Age);
	}

    Console.WriteLine("File has been written");
}

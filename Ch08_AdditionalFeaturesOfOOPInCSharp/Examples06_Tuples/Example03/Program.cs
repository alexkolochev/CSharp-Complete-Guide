// Кортеж как параметр метода
PrintPerson(("Tom", 37));
PrintPerson(("Bob", 41));

void PrintPerson((string name, int age) person)
{
    Console.WriteLine($"{person.name} - {person.age}");
}

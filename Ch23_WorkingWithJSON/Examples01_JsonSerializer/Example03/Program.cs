// Настройка сериализации с помощью JsonSerializerOptions
using Example03;
using System.Text.Json;

Person tom = new("Tom", 37);

var options = new JsonSerializerOptions
{
    WriteIndented = true
};

string json = JsonSerializer.Serialize(tom, options);
Console.WriteLine(json);
Person? restoredPerson = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(restoredPerson?.Name);

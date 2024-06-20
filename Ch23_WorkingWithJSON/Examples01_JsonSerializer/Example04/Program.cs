// Настройка сериализации с помощью атрибутов
using Example04;
using System.Text.Json;

Person tom = new("Tom", 37);

string json = JsonSerializer.Serialize(tom);
Console.WriteLine(json);
Person? person = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");

// Запись и чтение файла json
using Example02;
using System.Text.Json;

using (FileStream fs = new("user.json", FileMode.OpenOrCreate))
{
    Person tom = new("Tom", 37);
    await JsonSerializer.SerializeAsync(fs, tom);
    Console.WriteLine("Data has been saved to file");
}

using (FileStream fs = new("user.json", FileMode.OpenOrCreate))
{
    Person? person = await JsonSerializer.DeserializeAsync<Person>(fs);
    Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");
}

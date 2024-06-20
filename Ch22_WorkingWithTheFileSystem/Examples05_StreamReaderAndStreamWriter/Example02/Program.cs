// Чтение из файла и StreamReader
string path = "note.txt";

using (StreamReader reader = new(path))
{
    string text = await reader.ReadToEndAsync();
    Console.WriteLine(text);
}

using (StreamReader reader = new(path))
{
    string? line;

    while ((line = reader.ReadLine()) != null)
        Console.WriteLine(line);
}

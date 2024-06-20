// Чтение и запись файлов
string path = @"C:\SomeDir\test.txt";
string originalText = "Hello, Metanit.com";

await File.WriteAllTextAsync(path, originalText);
await File.AppendAllTextAsync(path, "\nHello, work");
// await File.WriteAllLinesAsync(path, [originalText, "Hello, work"]);

string fileText = await File.ReadAllTextAsync(path);
Console.WriteLine(fileText);
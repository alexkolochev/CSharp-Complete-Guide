// Кодировка
using System.Text;

string path = @"C:\SomeDir\test.txt";
string originalText = "Hello, Metanit.com";

await File.WriteAllTextAsync(path, originalText, Encoding.Unicode);
await File.AppendAllTextAsync(path, "\nПривет, мир", Encoding.Unicode);
string fileText1 = await File.ReadAllTextAsync(path, Encoding.Unicode);
Console.WriteLine(fileText1);

//await File.WriteAllTextAsync(path, originalText, Encoding.GetEncoding("iso-8859-1"));
//await File.AppendAllTextAsync(path, "\nHello, code", Encoding.GetEncoding("iso-8859-1"));
//string fileText2 = await File.ReadAllTextAsync(path, Encoding.GetEncoding("iso-8859-1"));
//Console.WriteLine(fileText2);

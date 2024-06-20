// Чтение и запись файлов
using System.Text;

string path = @"C:\SomeDir\text.txt";
string text = "Hello, METANIT.COM";

using (FileStream fstream = new(path, FileMode.OpenOrCreate))
{
    byte[] buffer = Encoding.Default.GetBytes(text);
    await fstream.WriteAsync(buffer, 0, buffer.Length);
    Console.WriteLine("Текст записан в файл");
}

using (FileStream fstream = File.OpenRead(path))
{
    byte[] buffer = new byte[fstream.Length];
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    string textFromFile = Encoding.Default.GetString(buffer);
    Console.WriteLine($"Текст из файла: {textFromFile}");
}

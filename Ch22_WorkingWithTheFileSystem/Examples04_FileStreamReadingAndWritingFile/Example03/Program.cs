// Произвольный доступ к файлам
using System.Text;

string path = "note.dat";
string text = "Hello, World!";

using (FileStream fstream = new(path, FileMode.OpenOrCreate))
{
    byte[] input = Encoding.Default.GetBytes(text);
    fstream.Write(input, 0, input.Length);
    Console.WriteLine("Текст записан в файл");
}

using (FileStream fstream = new(path, FileMode.OpenOrCreate))
{
    string replaceText = "house!";
    fstream.Seek(-6, SeekOrigin.End);
    byte[] input = Encoding.Default.GetBytes(replaceText);
    await fstream.WriteAsync(input, 0, input.Length);

    fstream.Seek(0, SeekOrigin.Begin);
    byte[] output = new byte[fstream.Length];
    await fstream.ReadAsync(output, 0, output.Length);
    string textFromFile = Encoding.Default.GetString(output);
    Console.WriteLine($"Текст из файла: {textFromFile}");
}

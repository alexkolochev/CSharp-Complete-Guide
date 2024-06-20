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
    // перемещаем указатель в конец файла, до конца файла-пять байт
    fstream.Seek(-6, SeekOrigin.End); // минус 5 символов с конца потока

    byte[] output = new byte[6];
    await fstream.ReadAsync(output, 0, output.Length);
    string textFromFile = Encoding.Default.GetString(output);
    Console.WriteLine($"Текст из файла: {textFromFile}");
}

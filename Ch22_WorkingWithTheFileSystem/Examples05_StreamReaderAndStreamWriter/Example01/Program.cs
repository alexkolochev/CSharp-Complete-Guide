// Запись в файл и StreamWriter
string path = "note.txt";
string text = "Hello, World!\nHello, METANIT.COM!";

// полная перезапись файла
using (StreamWriter writer = new(path, false))
{
    await writer.WriteAsync(text);
}

// добавление в файл
using (StreamWriter writer = new(path, true))
{
    await writer.WriteLineAsync("Additional");
    await writer.WriteAsync("4,5");
}

// Получение информации о файле
string path = @"C:\SomeDir\test.txt";
FileInfo fileInfo = new FileInfo(path);

if (fileInfo.Exists)
{
    Console.WriteLine($"Имя файла: {fileInfo.Name}");
    Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
    Console.WriteLine($"Размер: {fileInfo.Length}");
}

// Удаление каталога
FromDirectory();
Console.WriteLine();
FromDirectoryInfo();

void FromDirectory()
{
    string dirName = @"C:\SomeDir";

    if (Directory.Exists(dirName))
    {
        Directory.Delete(dirName, true);
        Console.WriteLine("Каталог удален");
    }
    else
    {
        Console.WriteLine("Каталог не существует");
    }
}

void FromDirectoryInfo()
{
    string dirName = @"C:\SomeDir";
    DirectoryInfo dirInfo = new DirectoryInfo(dirName);

    if (dirInfo.Exists)
    {
        dirInfo.Delete(true);
        Console.WriteLine("Каталог удален");
    }
    else
    {
        Console.WriteLine("Каталог не существует");
    }
}

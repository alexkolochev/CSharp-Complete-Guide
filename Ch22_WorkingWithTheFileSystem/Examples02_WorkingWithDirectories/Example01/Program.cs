// Получение списка файлов и подкаталогов
FromDirectory();
Console.WriteLine();
FromDirectoryInfo();

void FromDirectory()
{
    string dirName = @"C:\";

    if (Directory.Exists(dirName))
    {
        Console.WriteLine("Подкаталоги:");
        string[] dirs = Directory.GetDirectories(dirName);
        foreach (string dir in dirs)
        {
            Console.WriteLine(dir);
        }

        Console.WriteLine();

        Console.WriteLine("Файлы:");
        string[] files = Directory.GetFiles(dirName);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    }
}

void FromDirectoryInfo()
{
    string dirName = @"C:\";

    var directory = new DirectoryInfo(dirName);

    if (directory.Exists)
    {
        Console.WriteLine("Подкаталоги:");
        DirectoryInfo[] dirs = directory.GetDirectories();
        foreach (var dir in dirs)
        {
            Console.WriteLine(dir.FullName);
        }

        Console.WriteLine();

        Console.WriteLine("Файлы:");
        FileInfo[] files = directory.GetFiles();
        foreach (var file in files)
        {
            Console.WriteLine(file.FullName);
        }
    }
}

// Создание каталога
FromDirectory();
Console.WriteLine();
FromDirectoryInfo();

void FromDirectory()
{
    string path = @"C:\SomeDir";
    string subPath = @"program1\avalon";
    if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
    Directory.CreateDirectory($@"{path}\{subPath}");
}

void FromDirectoryInfo()
{
    string path = @"C:\SomeDir";
    string subPath = @"program2\avalon";
    DirectoryInfo dirInfo = new DirectoryInfo(path);
    if (!dirInfo.Exists)
    {
        dirInfo.Create();
    }
    dirInfo.CreateSubdirectory(subPath);
}

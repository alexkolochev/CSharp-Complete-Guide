// Перемещение каталога
FromDirectory();
Console.WriteLine();
FromDirectoryInfo();

void FromDirectory()
{
    string oldPath = @"C:\SomeFolder";
    string newPath = @"C:\SomeDir";

    if (Directory.Exists(oldPath) && !Directory.Exists(newPath))
    {
        Directory.Move(oldPath, newPath);
    }
}

void FromDirectoryInfo()
{
    string oldPath = @"C:\SomeFolder";
    string newPath = @"C:\SomeDir";
    DirectoryInfo dirInfo = new DirectoryInfo(oldPath);

    if (dirInfo.Exists && !Directory.Exists(newPath))
    {
        dirInfo.MoveTo(newPath);
    }
}

// Фильтрация папок и файлов
FromDirectory();
Console.WriteLine();
FromDirectoryInfo();

void FromDirectory()
{
    string dirName = @"C:\";

    string[] dirs = Directory.GetDirectories(dirName, "books*.");
    string[] files = Directory.GetFiles(dirName, "*.exe");
}

void FromDirectoryInfo()
{
    string dirName = @"C:\";
    var directory = new DirectoryInfo(dirName);

    DirectoryInfo[] dirs = directory.GetDirectories("books*.");
    FileInfo[] files = directory.GetFiles("*.exe");
}

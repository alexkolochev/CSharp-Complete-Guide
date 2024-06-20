// Копирование файла
string path = @"C:\SomeDir\test.txt";
string newPath = @"C:\SomeDir2\test2.txt";
FileInfo fileInfo = new FileInfo(path);
if (fileInfo.Exists)
{
    fileInfo.CopyTo(newPath, true);
    //File.Copy(path, newPath, true);
}

// Перемещение файла
string path = @"C:\SomeDir\test.txt";
string newPath = @"C:\SomeDir2\test.txt";
FileInfo fileInfo = new FileInfo(path);
if (fileInfo.Exists)
{
    fileInfo.MoveTo(newPath);
    //File.Move(path, newPath);
}

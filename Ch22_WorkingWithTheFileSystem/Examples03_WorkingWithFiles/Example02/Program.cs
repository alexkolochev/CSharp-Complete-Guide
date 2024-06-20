// Удаление файла
string path = @"C:\SomeDir\test.txt";
FileInfo fileInfo = new FileInfo(path);

if (fileInfo.Exists)
{
    fileInfo.Delete();
    //File.Delete(path);
}

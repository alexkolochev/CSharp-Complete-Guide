// ZipFile
using System.IO.Compression;

string sourceFolder = @"C:\test\";
string zipFile = @"C:\new\test.zip";
string targetFolder = @"C:\newtest";

ZipFile.CreateFromDirectory(sourceFolder, zipFile);
Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");

ZipFile.ExtractToDirectory(zipFile, targetFolder);
Console.WriteLine($"Файл {zipFile} распакован в папку {targetFolder}");

// GZipStream и DeflateStream
using System.IO.Compression;

string sourceFile = "book.pdf";
string compressedFile = "book.gz";
string targetFile = "book_new.pdf";

await CompressAsync(sourceFile, compressedFile);
await DecompressAsync(compressedFile, targetFile);

async Task CompressAsync(string sourceFile, string compressedFile)
{
    using FileStream sourceStream = new(sourceFile, FileMode.OpenOrCreate);
    using FileStream targetStream = File.Create(compressedFile);

    using GZipStream compressionStream = new(targetStream, CompressionMode.Compress);
    await sourceStream.CopyToAsync(compressionStream);

    Console.WriteLine($"Сжатие файла {sourceFile} завершено.");
    Console.WriteLine($"Исходный размер: {sourceStream.Length}. Сжатый размер: {targetStream.Length}");
}

async Task DecompressAsync(string compressedFile, string targetFile)
{
    using FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate);
    using FileStream targetStream = File.Create(targetFile);

    using GZipStream decompressionStream = new(sourceStream, CompressionMode.Decompress);
    await decompressionStream.CopyToAsync(targetStream);
    Console.WriteLine($"Восстановлен файл: {targetFile}");
}

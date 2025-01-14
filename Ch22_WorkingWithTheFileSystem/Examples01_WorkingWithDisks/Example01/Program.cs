﻿DriveInfo[] drives = DriveInfo.GetDrives();

foreach (var drive in drives)
{
    Console.WriteLine($"Название: {drive.Name}");
    Console.WriteLine($"Тип: {drive.DriveType}");
    if (drive.IsReady)
    {
        Console.WriteLine($"Объем диска: {drive.TotalSize}");
        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
        Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
    }
    Console.WriteLine();
}
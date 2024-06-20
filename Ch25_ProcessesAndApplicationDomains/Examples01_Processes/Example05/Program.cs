// Запуск нового процесса
using System.Diagnostics;

ProcessStartInfo procInfo = new();
procInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome";
procInfo.Arguments = "https://metanit.com";
Process.Start(procInfo);

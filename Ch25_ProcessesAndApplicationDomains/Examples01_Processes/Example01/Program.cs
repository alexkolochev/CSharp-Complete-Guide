using System.Diagnostics;

// Исследуем текущий процесс
var process = Process.GetCurrentProcess();
Console.WriteLine($"Id: {process.Id}");
Console.WriteLine($"Name: {process.ProcessName}");
Console.WriteLine($"VirtualMemory: {process.VirtualMemorySize64}");

Console.WriteLine();

// Получим все запущенные процессы
foreach (Process proc in Process.GetProcesses())
{
    Console.WriteLine($"ID: {proc.Id}  Name: {proc.ProcessName}");
}

Console.WriteLine();

// Получим id процессов, который представляют запущенные экземпляры Visual Studio
Process[] vsProcs = Process.GetProcessesByName("devenv");
//Process[] vsProcs = Process.GetProcessesByName("VisualStudio"); // для MacOS
foreach (Process proc in vsProcs)
    Console.WriteLine($"ID: {proc.Id}");

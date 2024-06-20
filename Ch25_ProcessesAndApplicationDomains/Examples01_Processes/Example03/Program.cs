// Модули процесса
using System.Diagnostics;

Process process = Process.GetProcessesByName("devenv")[0];
ProcessModuleCollection modules = process.Modules;

foreach (ProcessModule module in modules)
{
    Console.WriteLine($"Name: {module.ModuleName}; FileName: {module.FileName}");
}

// Потоки процесса
using System.Diagnostics;

Process proc = Process.GetProcessesByName("devenv")[0];
ProcessThreadCollection processThreads = proc.Threads;

foreach (ProcessThread thread in processThreads)
{
    Console.WriteLine($"ThreadID: {thread.Id}");
}

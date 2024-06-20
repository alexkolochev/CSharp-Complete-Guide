﻿int x = 0;
Mutex mutexObj = new();

for (int i = 1; i < 6; i++)
{
    Thread myThread = new(Print)
    {
        Name = $"Поток {i}"
    };
    myThread.Start();
}


void Print()
{
    mutexObj.WaitOne();
    x = 1;
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
        x++;
        Thread.Sleep(100);
    }
    mutexObj.ReleaseMutex();
}
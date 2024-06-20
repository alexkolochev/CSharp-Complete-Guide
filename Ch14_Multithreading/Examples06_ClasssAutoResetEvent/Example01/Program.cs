int x = 0;
AutoResetEvent waitHandler = new(true);

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
    waitHandler.WaitOne();
    //AutoResetEvent.WaitAll(new WaitHandle[] { waitHandler });
    x = 1;
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
        x++;
        Thread.Sleep(100);
    }
    waitHandler.Set();
}

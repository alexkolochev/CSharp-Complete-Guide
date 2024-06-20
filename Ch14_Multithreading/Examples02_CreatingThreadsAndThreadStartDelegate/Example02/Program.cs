Thread myThread = new Thread(Print);
myThread.Start();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Главный поток: {i}");
    Thread.Sleep(300);
}

void Print()
{
	for (int i = 0; i < 5; i++)
	{
        Console.WriteLine($"Второй поток: {i}");
        Thread.Sleep(400);
    }
}

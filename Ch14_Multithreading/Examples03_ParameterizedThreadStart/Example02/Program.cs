int number = 4;
Thread myThread = new Thread(Print);
myThread.Start(number);

void Print(object? obj)
{
    if (obj is int n)
        Console.WriteLine($"{n} * {n} = {n * n}");
}

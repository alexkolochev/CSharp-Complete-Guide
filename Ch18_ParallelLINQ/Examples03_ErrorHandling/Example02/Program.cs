﻿// Прерывание параллельной операции
CancellationTokenSource cts = new CancellationTokenSource();
new Task(() =>
{
    Thread.Sleep(400);
    cts.Cancel();
}).Start();

try
{
    int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8,];
    var squares = from n in numbers.AsParallel().WithCancellation(cts.Token)
                  select Square(n);

    foreach (var n in squares)
        Console.WriteLine(n);
}
catch (OperationCanceledException)
{
    Console.WriteLine("Операция была прервана");
}
catch (AggregateException ex)
{
    if (ex.InnerExceptions != null)
    {
        foreach (Exception e in ex.InnerExceptions)
            Console.WriteLine(e.Message);
    }
}
finally
{
    cts.Dispose();
}

int Square(int n)
{
    var result = n * n;
    Console.WriteLine($"Квадрат числа {n} равен {result}");
    Thread.Sleep(1000);
    return result;
}

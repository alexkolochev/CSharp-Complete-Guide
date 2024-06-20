// Передача токена во внешний метод
CancellationTokenSource cancelTokenSource = new();
CancellationToken token = cancelTokenSource.Token;

Task task = new Task(() => PrintSquares(token), token);
try
{
    task.Start();
    Thread.Sleep(1000);
    cancelTokenSource.Cancel();
    task.Wait();
}
catch (AggregateException ae)
{
    foreach (Exception e in ae.InnerExceptions)
    {
        if (e is TaskCanceledException)
            Console.WriteLine("Операция прервана");
        else
            Console.WriteLine(e.Message);
    }
}
finally
{
    cancelTokenSource.Dispose();
}
Console.WriteLine($"Task Status: {task.Status}");

void PrintSquares(CancellationToken token)
{
    for (int i = 1; i < 10; i++)
    {
        if (token.IsCancellationRequested)
            token.ThrowIfCancellationRequested();

        Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        Thread.Sleep(200);
    }
}

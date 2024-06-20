// Отмена задачи с помощью генерации исключения
/*
 * Исключение возникает только тогда,
 * когда мы останавливаем текущий поток и ожидаем завершения задачи с помощью методов Wait или WaitAll.
 * Если эти методы не используются для ожидания задачи, то для нее просто устанавливается состояние Canceled.
 */
CancellationTokenSource cancellationTokenSource = new();
CancellationToken token = cancellationTokenSource.Token;

Task task = new(() =>
{
    for (int i = 1; i < 10; i++)
    {
        if (token.IsCancellationRequested)
            token.ThrowIfCancellationRequested();

        Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        Thread.Sleep(200);
    }
}, token);

try
{
    task.Start();
    Thread.Sleep(1000);
    cancellationTokenSource.Cancel();
    task.Wait();
}
catch (AggregateException ae)
{
    foreach (Exception ex in ae.InnerExceptions)
    {
        if (ex is TaskCanceledException)
            Console.WriteLine("Операция прервана");
        else
            Console.WriteLine(ex.Message);
    }
}
finally
{
    cancellationTokenSource.Dispose();
}

Console.WriteLine($"Task Status: {task.Status}");

// Мягкий выход из задачи без исключения OperationCanceledException
CancellationTokenSource cancellationTokenSource = new();
CancellationToken token = cancellationTokenSource.Token;

Task task = new Task(() =>
{
    for (int i = 1; i < 10; i++)
    {
        if (token.IsCancellationRequested) // проверяем наличие сигнала отмены задачи
        {
            Console.WriteLine("Операция прервана");
            return;
        }
        Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        Thread.Sleep(200);
    }
}, token);
task.Start();

Thread.Sleep(1000);
cancellationTokenSource.Cancel(); // после задержки по времени отменяем выполнение задачи
Thread.Sleep(1000);
Console.WriteLine($"Task Status: {task.Status}");
cancellationTokenSource.Dispose();

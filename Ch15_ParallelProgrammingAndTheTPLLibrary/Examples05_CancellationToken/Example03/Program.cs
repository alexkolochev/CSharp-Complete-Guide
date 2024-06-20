// Регистрация обработчика отмены задачи
CancellationTokenSource cancellationTokenSource = new();
CancellationToken token = cancellationTokenSource.Token;

Task task = new(() =>
{
    int i = 1;
    token.Register(() =>
    {
        Console.WriteLine("Операция прервана");
        i = 10;
    });

    for (; i < 10; i++)
    {
        Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        Thread.Sleep(400);
    }
}, token);
task.Start();

Thread.Sleep(1000);
cancellationTokenSource.Cancel();
Thread.Sleep(1000);
Console.WriteLine($"Task Status: {task.Status}");
cancellationTokenSource.Dispose();

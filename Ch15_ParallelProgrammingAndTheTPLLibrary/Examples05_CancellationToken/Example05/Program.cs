// Отмена параллельных операций Parallel
CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
CancellationToken token = cancelTokenSource.Token;

new Task(() =>
{
    Thread.Sleep(400);
    cancelTokenSource.Cancel();
}).Start();

try
{
    Parallel.ForEach(new List<int> { 1, 2, 3, 4, 5 }, new ParallelOptions { CancellationToken = token }, Square);
}
catch (OperationCanceledException)
{
    Console.WriteLine("Операция прервана");
}
finally
{
    cancelTokenSource.Dispose();
}

void Square(int n)
{
    Thread.Sleep(3000);
    Console.WriteLine($"Квадрат числа {n} равен {n * n}");
}

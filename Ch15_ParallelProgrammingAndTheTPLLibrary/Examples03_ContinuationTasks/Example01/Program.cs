Task task1 = new(() =>
{
    Console.WriteLine($"Id задачи: {Task.CurrentId}");
});

Task task2 = task1.ContinueWith(PrintTask);
task1.Start();
task2.Wait();
Console.WriteLine("Конец метода Main");

void PrintTask(Task t)
{
    Console.WriteLine($"Id задачи: {Task.CurrentId}");
    Console.WriteLine($"Id предыдущей задачи: {t.Id}");
    Thread.Sleep(3000);
}

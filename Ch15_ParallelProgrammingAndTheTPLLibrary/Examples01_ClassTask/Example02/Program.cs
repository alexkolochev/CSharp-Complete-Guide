// Синхронный запуск задачи
Task task1 = new(() =>
{
    Console.WriteLine("Task1 Starts");
    Thread.Sleep(1000);
    Console.WriteLine("Task1 Ends");
});
task1.RunSynchronously();

Console.WriteLine("Main Ends");

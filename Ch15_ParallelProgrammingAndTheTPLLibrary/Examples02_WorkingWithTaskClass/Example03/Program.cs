// Массив задач
Task[] tasks = new Task[3];
for (var i = 0; i < tasks.Length; i++)
{
    tasks[i] = new Task(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Task{i} finished");
    });
    tasks[i].Start();
}
Console.WriteLine("Завершение метода Main");

Task.WaitAll(tasks);

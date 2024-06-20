// Task.WhenAll()
// Этот метод принимает набор асинхронных задач и ожидает завершения всех этих задач.
var task1 = PrintAsync("Hello, C#");
var task2 = PrintAsync("Hello, World");
var task3 = PrintAsync("Hello, METANIT.COM");

await Task.WhenAll(task1, task2, task3);

async Task PrintAsync(string message)
{
    await Task.Delay(2000);
    Console.WriteLine(message);
}

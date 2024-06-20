// Исследование исключения
var task = PrintAsync("Hi");
try
{
    await task;
}
catch
{
    Console.WriteLine(task.Exception?.InnerException?.Message);
    Console.WriteLine($"IsFaulted: {task.IsFaulted}");
    Console.WriteLine($"Status: {task.Status}");
}

async Task PrintAsync(string message)
{
    if (message.Length < 3)
        throw new ArgumentException($"Invalid string length: {message.Length}");
    await Task.Delay(1000);
    Console.WriteLine(message);
}
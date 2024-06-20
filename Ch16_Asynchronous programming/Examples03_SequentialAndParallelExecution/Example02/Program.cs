// Task.WhenAny()
var task1 = PrintAsync("Hello C#");
var task2 = PrintAsync("Hello World");
var task3 = PrintAsync("Hello METANIT.COM");

await Task.WhenAny(task1, task2, task3);

async Task PrintAsync(string message)
{
    await Task.Delay(new Random().Next(1000, 2000));
    Console.WriteLine(message);
}

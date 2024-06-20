// Task
var task = PrintAsync("Hello, Metanit.com");
Console.WriteLine("Main Works");

await task;

async Task PrintAsync(string message)
{
    await Task.Delay(0);
    Console.WriteLine(message);
}

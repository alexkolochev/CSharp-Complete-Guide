// Преимущества асинхронности
var tomTask = PrintNameAsync("Tom");
var bobTask = PrintNameAsync("Bob");
var samTask = PrintNameAsync("Sam");

await tomTask;
await bobTask;
await samTask;

async Task PrintNameAsync(string name)
{
    await Task.Delay(3000);
    Console.WriteLine(name);
}

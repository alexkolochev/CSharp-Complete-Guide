// Задержка асинхронной операции и Task.Delay
await PrintAsync();
Console.WriteLine("Некоторые действия в методе Main");

async Task PrintAsync()
{
    await Task.Delay(3000);
    //await Task.Delay(TimeSpan.FromMilliseconds(3000));
    Console.WriteLine("Hello, METANIT.COM");
}

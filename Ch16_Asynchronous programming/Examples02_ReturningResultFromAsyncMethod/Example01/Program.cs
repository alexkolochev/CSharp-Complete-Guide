// void
using Example01;

Account account = new();
account.Added += PrintAsync;
account.Put(500);

await Task.Delay(2000);

async void PrintAsync(object? obj, string message)
{
    await Task.Delay(1000);
    Console.WriteLine(message);
}

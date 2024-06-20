// Получение результата
var task1 = SquareAsync(4);
var task2 = SquareAsync(5);
var task3 = SquareAsync(6);

int[] results = await Task.WhenAll(task1, task2, task3);

foreach (var result in results)
    Console.WriteLine(result);

Console.WriteLine($"task2 result: {task2.Result}");

async Task<int> SquareAsync(int n)
{
    await Task.Delay(1000);
    return n * n;
}

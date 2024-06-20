await foreach (var number in GetNumbersAsync())
{
    Console.WriteLine(number);
}

async IAsyncEnumerable<int> GetNumbersAsync()
{
    for (int i = 0; i < 10; i++)
    {
        await Task.Delay(100);
        yield return i;
    }
}

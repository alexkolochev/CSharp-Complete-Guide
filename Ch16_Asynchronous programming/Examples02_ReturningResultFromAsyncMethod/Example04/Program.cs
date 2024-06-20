// ValueTask<T>
var result = await AddAsync(4, 5);
Console.WriteLine(result);

ValueTask<int> AddAsync(int a, int b)
{
    return new ValueTask<int>(a + b);
}

var getMessage = GetMessageAsync();
string message = await getMessage.AsTask();
Console.WriteLine(message);

async ValueTask<string> GetMessageAsync()
{
    await Task.Delay(0);
    return "Hello";
}

/*
 * Следует учитывать, что если асинхронный метод имеет тип void, 
 * то в этом случае исключение во вне не передается, 
 * соответственно мы не сможем обработать исключение при вызове метода.
 */
try
{
    await PrintAsync("Hello, METANIT.COM");
    await PrintAsync("Hi");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

async Task PrintAsync(string message)
{
    if (message.Length < 3)
        throw new ArgumentException($"Invalid string length: {message.Length}");

    await Task.Delay(100);
    Console.WriteLine(message);
}

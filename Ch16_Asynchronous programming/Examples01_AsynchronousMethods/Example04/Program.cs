// Определение асинхронного лямбда-выражения
Func<string, Task> printer = async (message) =>
{
    await Task.Delay(1000);
    Console.WriteLine(message);
};

await printer("Hello, World");
await printer("Hello, METANIT.COM");

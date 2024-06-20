using Example02;

Repository repository = new();
IAsyncEnumerable<string> data = repository.GetDataAsync();

await foreach (var name in data)
    Console.WriteLine(name);

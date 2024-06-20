await PrintAsync(); // вызов асинхронного метода
Console.WriteLine("Некоторые действия в методе Main");

void Print()
{
    Thread.Sleep(3000);
    Console.WriteLine("Hello, METANIT.COM");
}

async Task PrintAsync() // определение асинхронного метода
{
    Console.WriteLine("Начало метода PrintAsync");
    await Task.Run(Print); // выполняется асинхронно
    Console.WriteLine("Конец метода PrintAsync");
}

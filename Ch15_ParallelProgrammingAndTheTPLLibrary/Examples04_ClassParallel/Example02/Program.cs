// Parallel.For
Parallel.For(1, 5, Square);

void Square(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Console.WriteLine($"Квадрат числа {n} равен {n * n}");
    Thread.Sleep(2000);
}

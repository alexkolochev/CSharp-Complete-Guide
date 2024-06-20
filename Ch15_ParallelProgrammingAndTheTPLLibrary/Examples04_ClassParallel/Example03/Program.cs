// Parallel.ForEach
ParallelLoopResult result = Parallel.ForEach(
    new List<int>() { 1, 3, 5, 8 },
    Square
);

void Square(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Console.WriteLine($"Квадрат числа {n} равен {n * n}");
    Thread.Sleep(2000);
}

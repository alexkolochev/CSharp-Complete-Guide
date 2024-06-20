// Выход из цикла
ParallelLoopResult result = Parallel.For(1, 10, Square);
if (!result.IsCompleted)
    Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");

void Square(int n, ParallelLoopState pls)
{
    if (n == 5) pls.Break();

    Console.WriteLine($"Квадрат числа {n} равен {n * n}");
    Thread.Sleep(2000);
}

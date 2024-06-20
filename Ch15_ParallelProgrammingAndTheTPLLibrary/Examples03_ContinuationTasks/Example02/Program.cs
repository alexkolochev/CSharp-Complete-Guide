Task<int> sumTask = new(() => Sum(4, 5));
Task printTask = sumTask.ContinueWith(task => PrintResult(task.Result));

sumTask.Start();
printTask.Wait();
Console.WriteLine("Конец метода Main");

int Sum(int a, int b) => a + b;

void PrintResult(int sum) => Console.WriteLine($"Sum: {sum}");

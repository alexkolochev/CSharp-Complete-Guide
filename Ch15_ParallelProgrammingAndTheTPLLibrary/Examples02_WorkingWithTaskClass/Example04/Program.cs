// Возвращение результатов из задач
int n1 = 4;
int n2 = 5;
Task<int> sumTask = new Task<int>(() => Sum(n1, n2));
sumTask.Start();
int result = sumTask.Result;
Console.WriteLine($"{n1} + {n2} = {result}");

int Sum(int a, int b) => a + b;

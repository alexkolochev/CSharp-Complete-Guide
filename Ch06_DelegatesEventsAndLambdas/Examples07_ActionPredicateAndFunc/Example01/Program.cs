// Action
DoOperation(10, 6, Add);
DoOperation(10, 6, Multiply);

void DoOperation(int a, int b, Action<int, int> op) => op(a, b);

void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");

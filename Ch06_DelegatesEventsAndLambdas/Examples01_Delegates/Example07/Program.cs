// Вызов делегата
Message mes = Hello;
mes.Invoke();
Operation? op = Add;
op -= Add;
int? n = op?.Invoke(3, 4);
Console.WriteLine(n);

void Hello() => Console.WriteLine("Hello");

int Add(int x, int y) => x + y;

delegate int Operation(int x, int y);

delegate void Message();

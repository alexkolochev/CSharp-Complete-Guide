Thread myThread1 = new Thread(new ParameterizedThreadStart(Print));
Thread myThread2 = new Thread(Print);
Thread myThread3 = new Thread(message => Console.WriteLine(message));

myThread1.Start("Hello");
myThread2.Start("Привет");
myThread3.Start("Salut");

void Print(object? message) => Console.WriteLine(message);

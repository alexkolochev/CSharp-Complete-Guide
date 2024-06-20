Thread myThread1 = new Thread(Print);
Thread myThread2 = new Thread(new ThreadStart(Print));
Thread myThread3 = new Thread(() => Console.WriteLine("Hello, Threads"));

myThread1.Start();
myThread2.Start();
myThread3.Start();

void Print() => Console.WriteLine("Hello, Threads");

namespace Example01
{
    internal class Reader
    {
        private static Semaphore sem = new(3, 3);
        private Thread myThread;
        private int count = 3;

        public Reader(int i)
        {
            myThread = new(Read) { Name = $"Читатель {i}" };
            myThread.Start();
        }

        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");
                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");
                sem.Release();
                count--;
                Thread.Sleep(1000);
            }
        }
    }
}

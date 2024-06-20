namespace Example03
{
    internal class Printer
    {
        public void PrintMessage(string message, int times = 1)
        {
            while (times-- > 0) Console.WriteLine(message);
        }

        public void CreateMessage(out string message) => message = "Hello, Metanit.com";
    }
}

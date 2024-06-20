namespace Example07
{
    internal class Printer
    {
        public void PrintMessage(string message, int times)
        {
            while (times-- > 0) Console.WriteLine(message);
        }
    }
}

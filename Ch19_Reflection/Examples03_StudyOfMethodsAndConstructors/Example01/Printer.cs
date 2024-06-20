namespace Example01
{
    internal class Printer
    {
        public string DefaultMessage { get; set; } = "Hello";

        public void PrintMessage(string message, int times = 1)
        {
            while (times-- > 0) Console.WriteLine(message);
        }

        public string CreateMessage() => DefaultMessage;
    }
}

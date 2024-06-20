namespace Example02
{
    internal class Printer
    {
        public string DefaultMessage { get; set; } = "Hello";

        protected internal void PrintMessage(string message, int times = 1)
        {
            while (times-- > 0) Console.WriteLine(message);
        }

        private string CreateMessage() => DefaultMessage;
    }
}

namespace Example05
{
    internal class Printer
    {
        public string Text { get; }

        public Printer(string text) => Text = text;

        private void Print() => Console.WriteLine(Text);
    }
}

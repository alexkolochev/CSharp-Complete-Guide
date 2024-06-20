namespace Example04
{
    internal class Printer
    {
        public string Text { get; }

        public Printer(string text) => Text = text;

        public void Print() => Console.WriteLine(Text);
    }
}

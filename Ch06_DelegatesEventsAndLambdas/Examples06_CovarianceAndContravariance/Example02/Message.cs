namespace Example02
{
    internal class Message
    {
        public string Text { get; }

        public Message(string text) => Text = text;

        public virtual void Print() => Console.WriteLine($"Message: {Text}");
    }
}

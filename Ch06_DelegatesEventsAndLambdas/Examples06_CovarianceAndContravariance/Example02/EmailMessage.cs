using static System.Net.Mime.MediaTypeNames;

namespace Example02
{
    internal class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }

        public override void Print() => Console.WriteLine($"Email: {Text}");
    }
}

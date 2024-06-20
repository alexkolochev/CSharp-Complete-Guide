namespace Example01
{
    internal class PersonException : ArgumentException
    {
        public int Value { get; }

        public PersonException(string message, int value)
            : base(message)
        {
            Value = value;
        }
    }
}

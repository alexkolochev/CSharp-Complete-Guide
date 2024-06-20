namespace Example02
{
    internal class Person : IDisposable
    {
        public string Name { get; }

        public Person(string name) => Name = name;

        public void Dispose() => Console.WriteLine($"{Name} has been disposed");
    }
}

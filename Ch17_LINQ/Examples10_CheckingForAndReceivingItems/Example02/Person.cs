namespace Example02
{
    internal class Person
    {
        public string Name { get; }

        public Person(string name) => Name = name;

        public override bool Equals(object? obj) => obj is Person person && Name == person.Name;

        public override int GetHashCode() => Name.GetHashCode();
    }
}

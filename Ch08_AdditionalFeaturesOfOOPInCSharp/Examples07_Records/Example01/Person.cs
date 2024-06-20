namespace Example01
{
    public record Person
    {
        public string Name { get; init; }

        public Person(string name) => Name = name;
    }
}

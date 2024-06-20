namespace Example03
{
    internal record Person
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

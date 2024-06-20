namespace Example05
{
    internal class Person
    {
        public required string Name { get; set; }
        public required int Age { get; set; }

        public Person() { }

        public Person(string name)
        {
            Name = name;
        }
    }
}

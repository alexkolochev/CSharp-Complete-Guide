namespace Example04
{
    /*
    internal record Person
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
    }
    */
    
    internal record Person(string Name, int Age);
}

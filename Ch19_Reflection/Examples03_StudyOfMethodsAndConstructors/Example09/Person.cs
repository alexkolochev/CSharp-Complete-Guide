namespace Example09
{
    internal class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
        public Person(string name) : this(name, 1) { }

        private Person() : this("Tom") { }
    }
}

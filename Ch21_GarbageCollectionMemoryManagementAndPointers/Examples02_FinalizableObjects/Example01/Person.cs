namespace Example01
{
    internal class Person
    {
        public string Name { get; }

        public Person(string name) => Name = name;

        ~Person()
        {
            Console.WriteLine($"{Name} has deleted");
        }
    }
}

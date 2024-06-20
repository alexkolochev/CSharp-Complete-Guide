namespace Example02
{
    internal class Person : IEater, IMovable
    {
        public string Name { get; set; }

        public Person(string name) => Name = name;

        public void Eat() => Console.WriteLine($"{Name} eats");

        public void Move() => Console.WriteLine($"{Name} moves");
    }
}

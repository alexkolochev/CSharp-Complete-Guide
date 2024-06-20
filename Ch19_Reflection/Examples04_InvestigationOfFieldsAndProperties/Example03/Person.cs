namespace Example03
{
    internal class Person
    {
        public string Name { get; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print() => Console.WriteLine($"{Name} - {Age}");
    }
}

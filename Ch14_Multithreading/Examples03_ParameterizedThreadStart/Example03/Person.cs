namespace Example03
{
    internal record class Person(string Name, int Age)
    {
        public void Print()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
        }
    }
}

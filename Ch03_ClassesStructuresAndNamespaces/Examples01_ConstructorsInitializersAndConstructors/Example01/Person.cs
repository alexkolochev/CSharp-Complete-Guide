namespace Example01
{
    internal class Person(string name, int age)
    {
        public Person(string name) : this(name, 18) { }
        public void Print() => Console.WriteLine($"name: {name}, age: {age}");
    }
}

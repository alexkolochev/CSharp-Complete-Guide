namespace Example02
{
    internal class Person
    {
        private string name;
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            Age = age;
        }
        public void Print() => Console.WriteLine($"Name: {name} Age: {Age}");
    }
}

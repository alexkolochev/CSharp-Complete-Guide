namespace Example02
{
    internal class Person
    {
        private static int minAge = 1;
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print() => Console.WriteLine($"{name} - {age}");
    }
}

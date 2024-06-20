namespace Example01
{
    internal struct Person
    {
        public string name;
        public int age;

        public void Print() => Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }
}

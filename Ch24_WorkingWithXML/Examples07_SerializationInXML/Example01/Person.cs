namespace Example01
{
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

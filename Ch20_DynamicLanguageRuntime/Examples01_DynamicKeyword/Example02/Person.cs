namespace Example02
{
    internal class Person
    {
        public string Name { get; }
        public dynamic Age { get; set; }

        public Person(string name, dynamic age)
        {
            Name = name;
            Age = age;
        }

        public dynamic GetSalary(dynamic value, string format)
        {
            if (format == "string") return $"{value} euro";
            else if (format == "int") return value;
            return 0.0;
        }

        public override string ToString() => $"Name: {Name}; Age: {Age}";
    }
}

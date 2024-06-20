namespace Example02
{
    internal class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }

        public Person(string name, int age, Company work)
        {
            Name = name;
            Age = age;
            Work = work;
        }

        public object Clone() => new Person(Name, Age, new Company(Work.Name));
    }
}

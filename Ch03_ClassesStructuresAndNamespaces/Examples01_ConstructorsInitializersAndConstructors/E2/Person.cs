namespace Example02
{
    internal class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        }
    }
}

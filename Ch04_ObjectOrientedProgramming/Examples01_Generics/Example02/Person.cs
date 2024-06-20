namespace Example02
{
    internal class Person<T>
    {
        public static T? code;
        public T Id { get; set; }
        public string Name { get; set; }

        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

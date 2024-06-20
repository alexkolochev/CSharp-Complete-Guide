namespace Example01
{
    internal class Person<T>
    {
        public T Id { get; }

        public Person(T id)
        {
            Id = id;
        }
    }
}

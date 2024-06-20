namespace Example01
{
    internal class UniversalPerson<T> : Person<T>
    {
        public UniversalPerson(T id) : base(id) { }
    }
}

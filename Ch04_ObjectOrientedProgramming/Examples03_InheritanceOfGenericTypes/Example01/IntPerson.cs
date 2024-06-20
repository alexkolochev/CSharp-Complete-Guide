namespace Example01
{
    internal class IntPerson<T> : Person<int>
    {
        public T Code { get; set; }

        public IntPerson(int id, T code) : base(id)
        {
            Code = code;
        }
    }
}

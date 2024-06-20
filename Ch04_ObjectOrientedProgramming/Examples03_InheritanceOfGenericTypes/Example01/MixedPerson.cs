namespace Example01
{
    internal class MixedPerson<T, K> : Person<T>
        where K : struct
    {
        public K Code { get; set; }

        public MixedPerson(T id, K code) : base(id)
        {
            Code = code;
        }
    }
}

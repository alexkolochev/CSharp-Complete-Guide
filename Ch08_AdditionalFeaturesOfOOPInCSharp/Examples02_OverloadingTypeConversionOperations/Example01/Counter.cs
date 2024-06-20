namespace Example01
{
    internal class Counter
    {
        public int Seconds { get; set; }

        public static implicit operator Counter(int seconds)
        {
            return new Counter { Seconds = seconds };
        }

        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
    }
}

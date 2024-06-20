namespace Example01
{
    internal class Counter
    {
        public int Value { get; set; }

        public static Counter operator +(Counter counter1, Counter counter2)
        {
            return new Counter { Value = counter1.Value + counter2.Value };
        }

        public static int operator +(Counter counter, int val)
        {
            return counter.Value + val;
        }

        public static bool operator >(Counter counter1, Counter counter2)
        {
            return counter1.Value > counter2.Value;
        }

        public static bool operator <(Counter counter1, Counter counter2)
        {
            return counter1.Value < counter2.Value;
        }

        public static Counter operator ++(Counter counter)
        {
            return new Counter { Value = counter.Value + 10 };
        }

        public static bool operator true(Counter counter)
        {
            return counter.Value != 0;
        }

        public static bool operator false(Counter counter)
        {
            return counter.Value == 0;
        }

        public static bool operator !(Counter counter)
        {
            return counter.Value == 0;
        }
    }
}

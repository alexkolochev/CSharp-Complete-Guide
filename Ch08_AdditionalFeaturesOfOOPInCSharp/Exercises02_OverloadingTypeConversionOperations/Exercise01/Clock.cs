namespace Exercise01
{
    internal class Clock
    {
        public int Hours { get; set; }

        public static implicit operator Clock(int hours)
        {
            return new Clock { Hours = hours % 24 };
        }

        public static explicit operator int(Clock clock)
        {
            return clock.Hours;
        }
    }
}

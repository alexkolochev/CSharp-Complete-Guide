namespace Example02
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

        public static implicit operator Timer(Counter counter)
        {
            int hours = counter.Seconds / 3600;
            int minutes = counter.Seconds % 3600 / 60;
            int seconds = counter.Seconds % 60;

            return new Timer { Hours = hours, Minutes = minutes, Seconds = seconds };
        }

        public static explicit operator Counter(Timer timer)
        {

            int hours = timer.Hours * 3600;
            int minutes = timer.Minutes * 60;
            return new Counter { Seconds = hours + minutes + timer.Seconds };
        }
    }
}

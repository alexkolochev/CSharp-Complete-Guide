namespace Exercise01
{
    internal class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

        public State()
        {
            Population = 0;
            Area = 0;
        }

        public State(decimal population, decimal area)
        {
            Population = population;
            Area = area;
        }

        public static State operator +(State state1, State state2)
        {
            return new State(state1.Population + state2.Population, state1.Area + state2.Area);
        }

        public static bool operator >(State state1, State state2)
        {
            return state1.Population > state2.Population;
        }

        public static bool operator <(State state1, State state2)
        {
            return state1.Population < state2.Population;
        }
    }
}

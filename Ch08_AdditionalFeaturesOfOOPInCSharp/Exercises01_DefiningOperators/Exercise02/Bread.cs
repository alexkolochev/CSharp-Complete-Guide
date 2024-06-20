namespace Exercise02
{
    internal class Bread
    {
        public int Weight { get; set; }

        public Bread() { }

        public Bread(int weight) => Weight = weight;

        public static Sandwich operator +(Bread bread, Butter butter)
        {
            return new Sandwich(bread.Weight + butter.Weight);
        }
    }
}

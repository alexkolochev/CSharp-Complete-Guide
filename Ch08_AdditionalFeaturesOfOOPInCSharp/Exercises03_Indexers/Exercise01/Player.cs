namespace Exercise01
{
    internal class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Player() { Name = string.Empty; }

        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}

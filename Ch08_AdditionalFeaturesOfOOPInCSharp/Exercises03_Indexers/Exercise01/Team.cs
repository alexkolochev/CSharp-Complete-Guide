namespace Exercise01
{
    internal class Team
    {
        private Player[] _players = new Player[11];

        public Team() { }

        public Team(Player[] players)
        {
            if (players is not null && players.Length == 11)
                _players = players;
        }

        public Player this[int index]
        {
            get
            {
                if (index >= 0 && index < _players.Length)
                {
                    return _players[index];
                }
                return null;
            }

            set
            {
                if (index >= 0 && index < _players.Length)
                {
                    _players[index] = value;
                }
            }
        }
    }
}

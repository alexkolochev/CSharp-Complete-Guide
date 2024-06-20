namespace Example01
{
    internal class Account
    {
        private int _sum;
        private AccountHandler? _taken;

        public Account(int sum) => _sum = sum;

        public void RegisterHandler(AccountHandler del) => _taken += del;

        public void UnregisterHandler(AccountHandler del) => _taken -= del;

        public void Add(int sum) => _sum += sum;

        public void Take(int sum)
        {
            if (_sum > sum)
            {
                _sum -= sum;
                _taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
                _taken?.Invoke($"Недостаточно средств. Баланс: {_sum} у.е.");
            }
        }
    }

    public delegate void AccountHandler(string message);
}

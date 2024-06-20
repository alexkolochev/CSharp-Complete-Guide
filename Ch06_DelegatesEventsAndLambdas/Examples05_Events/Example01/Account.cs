namespace Example01
{
    internal class Account
    {
        public delegate void AccountHandler(Account sender, AccountEventArgs e);
        public event AccountHandler? Notify;
        /*
        private AccountHandler? _notify;
        public event AccountHandler Notify // Определение события
        {
            add
            {
                _notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }

            remove
            {
                _notify -= value;
                Console.WriteLine($"{value.Method.Name} удален");
            }
        }
        */

        public int Sum { get; private set; }

        public Account(int sum) => Sum = sum;

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило: {sum}", sum)); // Вызов события
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Со счета снято: {sum}", sum)); // Вызов события
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Недостаточно денег на счете. Текущий баланс: {Sum}", sum)); // Вызов события
            }
        }
    }
}

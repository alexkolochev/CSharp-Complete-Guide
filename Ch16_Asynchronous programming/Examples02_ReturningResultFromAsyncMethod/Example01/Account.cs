namespace Example01
{
    internal class Account
    {
        private int sum = 0;
        public event EventHandler<string> Added;

        public void Put(int sum)
        {
            this.sum += sum;
            Added?.Invoke(this, $"На счет поступило {sum} $");
        }
    }
}

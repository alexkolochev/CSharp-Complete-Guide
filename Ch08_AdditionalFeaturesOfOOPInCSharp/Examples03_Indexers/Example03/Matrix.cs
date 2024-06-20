namespace Example03
{
    internal class Matrix
    {
        private int[,] _numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };

        public int this[int i, int j]
        {
            get => _numbers[i, j];
            set => _numbers[i, j] = value;
        }
    }
}

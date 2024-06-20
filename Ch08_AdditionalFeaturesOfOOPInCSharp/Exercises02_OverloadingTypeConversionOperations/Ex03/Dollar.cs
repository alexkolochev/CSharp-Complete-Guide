namespace Exercise03
{
    internal class Dollar
    {
        public decimal Sum { get; set; }

        public static implicit operator Dollar(Euro euro)
        {
            return new Dollar { Sum = euro.Sum * 1.14m };
        }

        public static explicit operator Euro(Dollar dollar)
        {
            return new Euro { Sum = dollar.Sum / 1.14m };
        }
    }
}

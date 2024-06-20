namespace Exercise02
{
    internal class Celcius
    {
        public double Degrees { get; set; }

        public static implicit operator Celcius(Fahrenheit fahrenheit)
        {
            return new Celcius { Degrees = (double)5 / 9 * (fahrenheit.Degrees - 32) };
        }

        public static implicit operator Fahrenheit(Celcius celcius)
        {
            return new Fahrenheit { Degrees = (double)9 / 5 * celcius.Degrees + 32 };
        }
    }
}

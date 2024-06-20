namespace Example04
{
    internal class Person
    {
        private string name = string.Empty;

        public string Name
        {
            get { return name; }
            init
            {
                name = value;
                Email = $"{value}@gmail.com";
            }
        }

        public string Email { get; private init; } = string.Empty;
    }
}

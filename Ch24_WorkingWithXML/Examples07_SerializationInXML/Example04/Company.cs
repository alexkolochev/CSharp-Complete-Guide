namespace Example04
{
    public class Company
    {
        public string Name { get; set; } = "Undefined";

        public Company() { }

        public Company(string name) => Name = name;
    }
}

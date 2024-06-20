namespace Example02
{
    internal class Employee
    {
        public string Name { get; set; }
        public Company Company { get; set; }

        public Employee(string name, Company company)
        {
            Name = name;
            Company = company;
        }
    }
}

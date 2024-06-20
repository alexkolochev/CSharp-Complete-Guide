namespace Example07
{
    internal record Employee(string Name, int Age, string Company) : Person(Name, Age);
}

namespace Example05
{
    internal record Person(string Name, int Age)
    {
        public string Company { get; set; } = string.Empty;
    }
}

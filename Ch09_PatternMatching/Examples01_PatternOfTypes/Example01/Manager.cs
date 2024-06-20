namespace Example01
{
    internal class Manager : Employee
    {
        public bool IsOnVacation { get; set; }

        public override void Work() => Console.WriteLine("Manager works");
    }
}

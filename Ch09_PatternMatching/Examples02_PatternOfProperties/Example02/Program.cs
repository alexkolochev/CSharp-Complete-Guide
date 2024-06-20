// C# 10
using Example02;

var microsoft = new Company("Microsoft");
var google = new Company("Google");
var tom = new Employee("Tom", microsoft);
var bob = new Employee("Bob", google);

PrintCompany(tom);
PrintCompany(bob);

/*
void PrintCompany(Employee employee)
{
    if (employee is Employee { Company: { Title: "Microsoft" } })
    {
        Console.WriteLine($"{employee.Name} works in Microsoft");
    }
    else
    {
        Console.WriteLine($"{employee.Name} works someware");
    }
}
*/

void PrintCompany(Employee employee)
{
    if (employee is Employee { Company.Title: "Microsoft" })
    {
        Console.WriteLine($"{employee.Name} works in Microsoft");
    }
    else
    {
        Console.WriteLine($"{employee.Name} works someware");
    }
}

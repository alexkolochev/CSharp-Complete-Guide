// SelectMany и сведение объектов
using Example04;

var companies = new List<Company>
{
    new("Microsoft", [new Person("Tom"), new Person("Bob")]),
    new("Google", [new Person("Sam"), new Person("Mike")]),
};

//var employees = from c in companies
//                from emp in c.Staff
//                select emp;

//var employees = companies.SelectMany(c => c.Staff, (c, emp) => new { emp.Name, Company = c.Name });
var employees = from c in companies
                from emp in c.Staff
                select new { emp.Name, Company = c.Name };

foreach (var employee in employees)
    Console.WriteLine($"{employee.Name} - {employee.Company}");

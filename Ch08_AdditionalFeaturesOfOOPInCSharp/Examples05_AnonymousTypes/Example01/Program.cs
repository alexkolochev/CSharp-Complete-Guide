using Example01;

var user = new { Name = "Tom", Age = 34 };
var student = new { Name = "Alice", Age = 21 };
var manager = new { Name = "Bob", Age = 26, Company = "Microsoft" };
Console.WriteLine(user.GetType().Name);
Console.WriteLine(student.GetType().Name);
Console.WriteLine(manager.GetType().Name);

Person tom = new Person("Tom");
int age = 34;
var student2 = new { tom.Name, age };
Console.WriteLine(student2.Name);
Console.WriteLine(student2.age);

var people = new[]
{
    new { Name = "Tom" },
    new { Name = "Bob" }
};

foreach (var person in people)
{
    Console.WriteLine(person.Name);
}

using Example02;

dynamic tom = new Person("Tom", 22);
Console.WriteLine(tom);
Console.WriteLine(tom.GetSalary(28, "int"));

dynamic bob = new Person("Bob", "twenty-two");
Console.WriteLine(bob);
Console.WriteLine(bob.GetSalary("twenty-eight", "string"));

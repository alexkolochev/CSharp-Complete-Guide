// Освобождение множества ресурсов
using Example03;

Test();

void Test()
{
    //using (Person tom = new("Tom"))
    //{
    //    using (Person bob = new("Bob"))
    //    {
    //        Console.WriteLine($"Person1: {tom.Name}\tPerson2: {bob.Name}");
    //    }
    //}

    //using (Person tom = new("Tom"))
    //using (Person bob = new("Bob"))
    //{
    //    Console.WriteLine($"Person1: {tom.Name}\tPerson2: {bob.Name}");
    //}

    using Person tom = new("Tom");
    using Person bob = new("Bob");
    Console.WriteLine($"Person1: {tom.Name}\tPerson2: {bob.Name}");

    Console.WriteLine("Конец метода Test");
}

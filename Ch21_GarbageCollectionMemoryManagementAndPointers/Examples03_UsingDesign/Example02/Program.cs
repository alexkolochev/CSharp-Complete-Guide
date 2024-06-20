// C# 8
using Example02;

Test();

void Test()
{
    // переменная должна быть удалена в конце области видимости - то есть в конце метода Test
    using Person tom = new("Tom");
    Console.WriteLine($"Name: {tom.Name}");
    Console.WriteLine("Конец метода Test");
}

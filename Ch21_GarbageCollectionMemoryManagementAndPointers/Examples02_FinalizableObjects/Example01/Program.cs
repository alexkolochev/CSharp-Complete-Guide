// Создание деструкторов
using Example01;

Test();
GC.Collect();
Console.Read();

void Test()
{
    Person tom = new("Tom");
}

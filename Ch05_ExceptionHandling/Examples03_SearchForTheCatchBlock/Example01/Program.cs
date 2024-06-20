// Поиск блока catch при обработке исключений
using Example01;

try
{
    TestClass.Method1();
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Catch в Main: {ex.Message}");
}
finally
{
    Console.WriteLine("Блок finally в Main");
}

Console.WriteLine("Конец метода Main");

using System.Reflection;
using System.Runtime.Loader;

Square(8);

Console.WriteLine();

GC.Collect();
GC.WaitForPendingFinalizers();

foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
    Console.WriteLine(asm.GetName().Name);

void Square(int number)
{
    var context = new AssemblyLoadContext("Square", true);
    context.Unloading += Context_Unloading; // установка обработчика выгрузки

    var assemblyPath = Path.Combine(Directory.GetCurrentDirectory(), "MyApp.dll"); // получаем путь к сборке MyApp
    Assembly assembly = context.LoadFromAssemblyPath(assemblyPath); // загружаем сборку

    var type = assembly.GetType("MyApp.Program"); // получаем тип Program из сборки MyApp.dll
    if (type is not null)
    {
        var squareMethod = type.GetMethod("Square", BindingFlags.Static | BindingFlags.NonPublic); // получаем его метод Square
        var result = squareMethod?.Invoke(null, [number]); // вызываем метод
        if (result is int)
        {
            Console.WriteLine($"Квадрат числа {number} равен {result}");
        }
    }

    // смотим, какие сборки у нас загружены
    foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        Console.WriteLine(asm.GetName().Name);

    context.Unload(); // выгружаем контекст
}

void Context_Unloading(AssemblyLoadContext obj)
{
    Console.WriteLine("Библиотека MyApp выгружена");
}
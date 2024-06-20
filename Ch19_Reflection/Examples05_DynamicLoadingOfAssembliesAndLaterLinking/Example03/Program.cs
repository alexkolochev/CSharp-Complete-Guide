// Позднее связывание
using System.Reflection;

Assembly asm = Assembly.LoadFrom("MyApp.dll");

Type? t = asm.GetType("MyApp.Program");

if (t is not null)
{
    MethodInfo? square = t.GetMethod("Square", BindingFlags.NonPublic | BindingFlags.Static);
    object? result = square?.Invoke(null, [7]);
    Console.WriteLine(result);

    MethodInfo? main = t.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static);
    main?.Invoke(null, [new string[] { }]);
}    

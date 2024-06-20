// BindingFlags
using Example02;
using System.Reflection;

Type myType = typeof(Printer);

Console.WriteLine("Методы:");
foreach (MethodInfo method in myType.GetMethods(BindingFlags.DeclaredOnly
            | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
{
    Console.WriteLine($"{method.ReturnType.Name} {method.Name}()");
}

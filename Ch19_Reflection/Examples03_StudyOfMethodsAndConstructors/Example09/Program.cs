// Получение конструкторов
using Example09;
using System.Reflection;

Type myType = typeof(Person);
Console.WriteLine("Конструкторы:");
foreach (var ctor in myType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
{
    string modificator = string.Empty;

    if (ctor.IsPublic)
        modificator = "public";
    else if (ctor.IsPrivate)
        modificator = "private";
    else if (ctor.IsAssembly)
        modificator = "internal";
    else if (ctor.IsFamily)
        modificator = "protected";
    else if (ctor.IsFamilyAndAssembly)
        modificator = "private protected";
    else if (ctor.IsFamilyOrAssembly)
        modificator = "protected internal";

    Console.Write($"{modificator} {myType.Name}(");
    ParameterInfo[] parameters = ctor.GetParameters();
    for (int i = 0; i < parameters.Length; i++)
    {
        var param = parameters[i];
        Console.Write($"{param.ParameterType.Name} {param.Name}");
        if (i < parameters.Length - 1) Console.Write(", ");
    }
    Console.WriteLine(")");
}

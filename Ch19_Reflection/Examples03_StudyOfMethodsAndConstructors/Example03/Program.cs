// Исследование параметров
using Example03;
using System.Reflection;

foreach (var method in typeof(Printer).GetMethods())
{
    Console.Write($"{method.ReturnType.Name} {method.Name} (");
    ParameterInfo[] parameters = method.GetParameters();
    for (int i = 0; i < parameters.Length; i++)
    {
        var param = parameters[i];
        string modificator = string.Empty;
        if (param.IsIn) modificator = "in";
        else if (param.IsOut) modificator = "out";

        Console.Write($"{param.ParameterType.Name} {modificator} {param.Name}");
        if (param.HasDefaultValue) Console.Write($"={param.DefaultValue}");
        if (i < parameters.Length - 1) Console.Write(", ");
    }
    Console.WriteLine(")");
}

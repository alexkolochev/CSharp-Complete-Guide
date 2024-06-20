// Свойства
using Example03;
using System.Reflection;

Type myType = typeof(Person);

foreach (PropertyInfo prop in myType.GetProperties(
    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
{
    Console.Write($"{prop.PropertyType} {prop.Name} {{ ");

    if (prop.CanRead) Console.Write("get;");
    if (prop.CanWrite) Console.Write("set;");
    Console.WriteLine(" }");
}

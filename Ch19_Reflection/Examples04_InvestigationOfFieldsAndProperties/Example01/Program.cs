// Получение информации о полях
using Example01;
using System.Reflection;

Type myType = typeof(Person);

Console.WriteLine("Поля:");
foreach (FieldInfo field in myType.GetFields(
    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
{
    string modificator = string.Empty;

    if (field.IsPublic)
        modificator = "public ";
    else if (field.IsPrivate)
        modificator = "private ";
    else if (field.IsAssembly)
        modificator = "internal ";
    else if (field.IsFamily)
        modificator = "protected ";
    else if (field.IsFamilyAndAssembly)
        modificator = "private protected ";
    else if (field.IsFamilyOrAssembly)
        modificator = "protected internal ";

    if (field.IsStatic) modificator += "static ";

    Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
}

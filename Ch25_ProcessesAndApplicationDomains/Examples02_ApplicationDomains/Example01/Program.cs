// Получим имя и базовый каталог текущего домена и выведем все загруженные в домен сборки
using System.Reflection;

AppDomain domain = AppDomain.CurrentDomain;
Console.WriteLine($"Name: {domain.FriendlyName}");
Console.WriteLine($"Base Directory: {domain.BaseDirectory}");
Console.WriteLine();

Assembly[] assemblies = domain.GetAssemblies();
foreach (Assembly assembly in assemblies)
    Console.WriteLine(assembly.GetName().Name);

using System.Reflection;

Assembly asm = Assembly.LoadFrom("MyApp.dll");
Console.WriteLine(asm.FullName);

Type[] types = asm.GetTypes();
foreach (Type t in types)
{
    Console.WriteLine(t.Name);
}

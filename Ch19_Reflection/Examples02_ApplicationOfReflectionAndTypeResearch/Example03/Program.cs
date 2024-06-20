// Получение одного компонента по имени
using Example03;
using System.Reflection;

Type myType = typeof(Person);
MemberInfo[] print = myType.GetMember("Print", BindingFlags.Instance | BindingFlags.Public);
foreach (MemberInfo member in print)
{
    Console.WriteLine($"{member.MemberType} {member.Name}");
}

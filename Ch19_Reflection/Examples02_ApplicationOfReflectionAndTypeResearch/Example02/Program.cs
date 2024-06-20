// BindingFlags
using Example02;
using System.Reflection;

Type myType = typeof(Person);

foreach (var member in myType.GetMembers(BindingFlags.DeclaredOnly
    | BindingFlags.Instance
    | BindingFlags.NonPublic
    | BindingFlags.Public))
{
    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
}

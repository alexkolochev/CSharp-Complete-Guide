// Получение всех компонентов типа
using Example01;

Type myType = typeof(Person);

foreach (var member in myType.GetMembers())
    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");

// Получение типа
using Example01;

Type myType1 = typeof(Person);
Console.WriteLine(myType1);

Person tom = new("Tom");
Type myType2 = tom.GetType();
Console.WriteLine(myType2);

Type? myType3 = Type.GetType("Example01.Person", false, true);
Console.WriteLine(myType3);

// Если нужный нам тип находится в другой сборке dll,
// то после полного имени класса через запятую указывается имя сборки
Type myType4 = Type.GetType("PeopleTypes.Person, MyLibrary", false, true);

Type myType = typeof(Person);
Console.WriteLine($"Name: {myType.Name}");
Console.WriteLine($"Full name: {myType.FullName}");
Console.WriteLine($"Namespace: {myType.Namespace}");
Console.WriteLine($"Is struct: {myType.IsValueType}");
Console.WriteLine($"Is class: {myType.IsClass}");

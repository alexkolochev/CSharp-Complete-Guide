using Example01;

dynamic obj = 3;
Console.WriteLine(obj);

obj = "Hello, World!";
Console.WriteLine(obj);

obj = new Person("Tom", 37);
Console.WriteLine(obj);

object obj2 = 24;
dynamic dyn = 24;
// obj2 += 4; // так нельзя
dyn += 4;

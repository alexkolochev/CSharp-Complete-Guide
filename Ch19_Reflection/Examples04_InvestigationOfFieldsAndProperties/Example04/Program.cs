// Свойства
using Example04;

Type myType = typeof(Person);
Person tom = new("Tom", 37);

var ageProp = myType.GetProperty("Age");
var age = ageProp?.GetValue(tom);
Console.WriteLine(age);

ageProp?.SetValue(tom, 22);
tom.Print();

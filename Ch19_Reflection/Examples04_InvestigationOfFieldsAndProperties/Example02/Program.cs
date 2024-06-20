// Получение и изменение значения поля
using Example02;
using System.Reflection;

Type myType = typeof(Person);
Person tom = new("Tom", 37);

var name = myType.GetField("name", BindingFlags.Instance | BindingFlags.NonPublic);

var value = name?.GetValue(tom);
Console.WriteLine(value);

name?.SetValue(tom, "Bob");
tom.Print();

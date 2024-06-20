// ExpandoObject позволяет создавать динамические объекты, наподобие тех, что используются в javascript
using System.Dynamic;

// определяем объект, который будет хранять ряд значений
dynamic person = new ExpandoObject();
person.Name = "Tom";
person.Age = 46;
person.Languages = new List<string> { "english", "german", "french" };

Console.WriteLine($"{person.Name} - {person.Age}");
foreach (var lang in person.Languages)
    Console.WriteLine(lang);

// объявляем метод
person.IncrementAge = (Action<int>)(x => person.Age += x);
person.IncrementAge(6);
Console.WriteLine($"{person.Name} - {person.Age}");

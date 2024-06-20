// DynamicObject похож на ExpandoObject, но для более сложных ситуаций
using Example02;

// создаем объект
dynamic person = new PersonObject();

// устанавливаем ряд свойств
person.Name = "Tom";
person.Age = 23;

// определяем метод для изменения свойства Age
Func<int, int> increment = (int n) => { person.Age += n; return person.Age; };
person.IncrementAge = increment;

Console.WriteLine($"{person.Name} - {person.Age}");
person.IncrementAge(4);
Console.WriteLine($"{person.Name} - {person.Age}");

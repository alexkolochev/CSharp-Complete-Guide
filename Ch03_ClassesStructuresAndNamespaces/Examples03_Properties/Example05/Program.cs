// Модификатор required

using Example05;

// Person person = new Person(); // ошибка - свойства Name и Age не инициализированы
// Person bob = new Person("Bob"); // ошибка - свойства Name и Age все равно надо установить в инициализаторе
Person tom = new Person { Name = "Tom", Age = 38 };
Console.WriteLine(tom.Name);
Console.WriteLine(tom.Age);

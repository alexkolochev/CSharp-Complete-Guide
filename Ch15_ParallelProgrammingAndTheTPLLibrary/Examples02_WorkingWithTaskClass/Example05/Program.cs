// Возвращение результатов из задач
using Example05;

Task<Person> defaultPersonTask = new(() => new Person("Tom", 37));
defaultPersonTask.Start();

Person defaultPerson = defaultPersonTask.Result;
Console.WriteLine($"{defaultPerson.Name} - {defaultPerson.Age}");

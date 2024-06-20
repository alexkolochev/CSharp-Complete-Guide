// Атрибуты в .NET
using Example01;

Person tom = new Person("Tom", 35);
Person bob = new Person("Bob", 16);

bool tomIsValid = ValidateUser(tom);
bool bobIsValid = ValidateUser(bob);

Console.WriteLine($"Результат валидации Тома: {tomIsValid}");
Console.WriteLine($"Результат валидации Боба: {bobIsValid}");

bool ValidateUser(Person person)
{
    Type type = typeof(Person);
    object[] attributes = type.GetCustomAttributes(false);

    foreach (Attribute attribute in attributes)
    {
        if (attribute is AgeValidationAttribute ageAttribute)
            return person.Age == ageAttribute.Age;
    }

    return true;
}

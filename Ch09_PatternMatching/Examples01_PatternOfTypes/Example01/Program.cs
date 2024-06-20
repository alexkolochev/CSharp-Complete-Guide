/*
 * Pattern matching фактически выполняет сопоставление некоторого значения с некоторым шаблоном. 
 * И если сопоставление прошло успешно, то выполняются определенные действия.
 * Язык C# позволяет выполнять различные типы сопоставлений.
 * Паттерн типов или type pattern позволяет проверить некоторое значение на соответствие некоторому типу:
 * значение is тип переменная_типа
 */

using Example01;

Employee bob = new Manager() { IsOnVacation = true };
Employee tom = new Manager() { IsOnVacation = false };
UseEmployee(tom);
UseEmployee(bob);

// проверяем, соответствует ли значение message строке "hello"
var message = "hello";
if (message is "hello")
    Console.WriteLine("hello");

/*
void UseEmployee(Employee employee)
{
    if (employee is Manager manager && !manager.IsOnVacation)
    {
        manager.Work();
    }
    else
    {
        Console.WriteLine("Преобразование недопустимо");
    }
}
*/

/*
void UseEmployee(Employee? employee)
{
    if (employee is not null)
        employee.Work();
}
*/

/*
void UseEmployee(Employee? employee)
{
    switch (employee)
    {
        case Manager manager:
            manager.Work();
            break;
        case null:
            Console.WriteLine("Object is null");
            break;
        default:
            Console.WriteLine("Object is not manager");
            break;
    }
}
*/

void UseEmployee(Employee? employee)
{
    switch (employee)
    {
        case Manager manager when !manager.IsOnVacation:
            manager.Work();
            break;
        case null:
            Console.WriteLine("Object is null");
            break;
        default:
            Console.WriteLine("Object is not manager");
            break;
    }
}

/*
 * Измените предыдущую программу. 
 * Пусть пользователь кроме номера операции вводит два числа, 
 * и в зависимости от номера операции с введенными числами выполняются определенные действия 
 * (например, при вводе числа 3 числа умножаются). Результат операции выводиться на консоль.
 */
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите номер операции: 1. Сложение; 2. Вычитание; 3. Умножение; 4. Деление");
int operation = Convert.ToInt32(Console.ReadLine());

double? result = operation switch
{
    1 => num1 + num2,
    2 => num1 - num2,
    3 => num1 * num2,
    4 => num1 / num2,
    _ => null
};

Console.WriteLine(result != null ? $"Результат операции: {result}" : "Операция не определена");

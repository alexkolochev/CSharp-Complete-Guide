/*
 * Реляционный паттерн позволяет сравнить передаваемое в конструкцию значение
 * с некоторыми значениями с помощью операций сравнения.
 * Например, в зависимости от суммы вклада проценты по этому вкладу могут отличаться.
 */
Console.WriteLine(Calculate(-200));
Console.WriteLine(Calculate(0));
Console.WriteLine(Calculate(10000));
Console.WriteLine(Calculate(60000));
Console.WriteLine(Calculate(200000));

decimal Calculate(decimal sum)
{
    return sum switch
    {
        <= 0 => 0,              // если sum меньше или равно 0, возвращаем 0
        < 50000 => sum * 0.05m, // если sum меньше 50000, возвращаем sum * 0.05m
        < 100000 => sum * 0.1m, // если sum меньше 100000, возвращаем sum * 0.1m
        _ => sum * 0.2m         // в остальных случаях возвращаем sum * 0.2m
    };
}

/*
 * Логический паттерн позволяет использовать логические операторы and (логическое умножение или операция логического И)
 * и or (логическое сложение или операция логического ИЛИ) для объединения операций сравнения.
 */
Console.WriteLine(CheckAge(200));
Console.WriteLine(CheckAge(0));
Console.WriteLine(CheckAge(17));
Console.WriteLine(CheckAge(18));
string CheckAge(int age)
{
    return age switch
    {
        < 1 or > 110 => "Недействительный возраст",
        >= 1 and < 18 => "Доступ запрещен",
        _ => "Доступ разрешен"
    };
}

string CheckAge2(int age) => age switch
{
    not 33 => "Обычный возраст",
    _ => "Вам 33 года"
};

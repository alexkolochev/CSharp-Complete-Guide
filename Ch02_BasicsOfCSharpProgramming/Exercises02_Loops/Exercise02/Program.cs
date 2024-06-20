/*
 * Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
 */
Console.Write("Введите сумму вклада: ");
decimal deposit = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите количество месяцев: ");
int months = Convert.ToInt32(Console.ReadLine());
int currentMonth = months;

while (currentMonth-- > 0)
{
    deposit *= 1.07m;
}

Console.WriteLine($"Через {months} месяц(-а/-ев) сумма вклада будет равна {deposit}");

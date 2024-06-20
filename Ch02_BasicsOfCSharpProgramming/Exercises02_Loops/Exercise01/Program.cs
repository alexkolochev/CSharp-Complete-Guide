﻿/*
 * За каждый месяц банк начисляет к сумме вклада 7% от суммы. 
 * Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. 
 * А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
 * 
 * Для вычисления суммы с учетом процентов используйте цикл for. 
 * Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) 
 * (сумма вклада будет представлять тип decimal).
 */
Console.Write("Введите сумму вклада: ");
decimal deposit = Convert.ToDecimal(Console.ReadLine());
Console.Write("Введите количество месяцев: ");
int months = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < months; i++)
    deposit *= 1.07m;

Console.WriteLine($"Через {months} месяц(-а/-ев) сумма вклада будет равна {deposit}");

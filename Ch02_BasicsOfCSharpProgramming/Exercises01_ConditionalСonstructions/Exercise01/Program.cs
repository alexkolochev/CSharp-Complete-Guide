﻿/*
 * Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. 
 * А программа сранивает два введенных числа и выводит на консоль результат сравнения 
 * (два числа равны, первое число больше второго или первое число меньше второго).
 */
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine("Первое число больше второго");
else if (num1 < num2)
    Console.WriteLine("Второе число больше первого");
else
    Console.WriteLine("Два числа равны");

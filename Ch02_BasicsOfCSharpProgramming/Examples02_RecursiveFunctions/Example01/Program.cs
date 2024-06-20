﻿/*
 * Рекурсивная функция факториала
 */
int Factorial(int n)
{
    if (n == 1)
        return 1;

    return n * Factorial(n - 1);
}

int factorial4 = Factorial(4);
int factorial5 = Factorial(5);
int factorial6 = Factorial(6);

Console.WriteLine($"Факториал числа 4 = {factorial4}");
Console.WriteLine($"Факториал числа 5 = {factorial5}");
Console.WriteLine($"Факториал числа 6 = {factorial6}");

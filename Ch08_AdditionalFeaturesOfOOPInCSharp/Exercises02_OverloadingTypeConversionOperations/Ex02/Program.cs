/*
 * Даны следующие классы: Celcius и Fahrenheit.
 * Класс Celcius представляет градусник по Цельсию, а Fahrenheit - градусник по Фаренгейту.
 * Определите операторы преобразования от типа Celcius и наоборот.
 * Преобразование температуры по шкале Фаренгейта (Tf) в температуру по шкале Цельсия (Tc): Tc = 5/9 * (Tf - 32).
 * Преобразование температуры по шкале Цельсия в температуру по шкале Фаренгейта: Tf = 9/5 * Tc + 32.
 */
using Exercise02;

Celcius celcius = new Celcius { Degrees = 25 };
Fahrenheit fahrenheit = celcius;
Console.WriteLine(fahrenheit.Degrees);
celcius = fahrenheit;
Console.WriteLine(celcius.Degrees);

/*
 * Дан класс Clock, который хранит количество часов.
 * В программе мы можем из числа получить количество часов и, наоборот, из количество часов значение типа int.
 * Добавьте в класс Clock оператор для неявного преобразования от типа int к типу Clock
 * и оператор явного преобразования от типа Clock к типу int.
 */
using Exercise01;

Clock clock = new Clock { Hours = 15 };

int x = (int)clock;
Console.WriteLine(x);

Clock clock2 = 13;
Console.WriteLine(clock2.Hours);
clock2 = 34;
Console.WriteLine(clock2.Hours);

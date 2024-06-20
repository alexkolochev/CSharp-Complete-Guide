/*
 * Напишите программу, которая выводит на консоль таблицу умножения
 */

for (int i = 0; i <= 9; i++)
{
    Console.Write(i == 0 ? "\t" : $" {i}\t");
}

Console.WriteLine();

for (int i = 1; i <= 9; i++)
{
    Console.Write($"{i}\t");

	for (int j = 1; j <= 9; j++)
	{
        Console.Write($"|{i * j}\t");
    }
    Console.WriteLine();
}

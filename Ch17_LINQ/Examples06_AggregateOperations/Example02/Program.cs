// Получение размера выборки. Метод Count
int[] numbers = [1, 2, 3, 4, 10, 34, 55, 66, 77, 88];

int size1 = numbers.Count();
Console.WriteLine(size1);

int size2 = numbers.Count(i => i % 2 == 0 && i > 10);
Console.WriteLine(size2);

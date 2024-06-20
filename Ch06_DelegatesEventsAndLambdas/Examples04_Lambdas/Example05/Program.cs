// Лямбда-выражение как аргумент метода
int[] integers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

int result1 = Sum(integers, x => x > 5);
Console.WriteLine(result1);

int result2 = Sum(integers, x => x % 2 == 0);
Console.WriteLine(result2);

int Sum(int[] numbers, IsEqual func)
{
    int result = 0;

    foreach (int number in numbers)
    {
        if (func(number))
            result += number;
    }

    return result;
}

delegate bool IsEqual(int x);

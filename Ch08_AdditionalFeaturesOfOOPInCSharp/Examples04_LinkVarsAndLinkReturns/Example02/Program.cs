// Ссылка как результат функции
int[] numbers = [1, 2, 3, 4, 5, 6, 7];
ref int numberRef = ref Find(4, numbers);
numberRef = 9;
Console.WriteLine(numbers[3]);

ref int Find(int number, int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == number)
            return ref numbers[i];
    }

    throw new IndexOutOfRangeException("Число не найдено");
}

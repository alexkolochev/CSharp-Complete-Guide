// Указатели на массивы и stackalloc
Square();
Factorial();

void Square()
{
    unsafe
    {
        const int size = 7;
        int* square = stackalloc int[size]; // выделяем память в стеке под семь объектов int
        int* p = square;

        // вычисляем квадраты чисел от 1 до 7 включая
        for (int i = 1; i <= size; i++, p++)
        {
            *p = i * i;
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(square[i]);
        }
    }
}

void Factorial()
{
    unsafe
    {
        const int size = 7;
        int* factorial = stackalloc int[size]; // выделяем память в стеке под семь объектов int
        int* p = factorial;

        *p++ = 1; // присваиваем первой ячейке значение 1 и
        // увеличиваем указатель на 1
        for (int i = 2; i <= size; i++, p++)
        {
            *p = p[-1] * i;
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(factorial[i]);
        }
    }
}

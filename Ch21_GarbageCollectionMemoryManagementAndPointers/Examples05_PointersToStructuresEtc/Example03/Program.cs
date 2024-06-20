// Оператор fixed и закрепление указателей
using Example03;

FixedClass();
FixedArray();

void FixedClass()
{
    unsafe
    {
        Point point = new Point();

        // блок фиксации указателя
        fixed (int* pX = &point.x)
        {
            *pX = 30;
        }
        fixed (int* pY = &point.y)
        {
            *pY = 150;
        }

        // можно совместить оба блока
        //fixed (int* pX = &point.x, pY = &point.y)
        //{
        //    *pX = 30;
        //    *pY = 150;
        //}

        Console.WriteLine(point);
    }
}

// Кроме адреса переменной можно также инициализировать указатель, используя массив,
// строку или буфер фиксированного размера
void FixedArray()
{
    unsafe
    {
        int[] nums = [0, 1, 2, 3, 7, 88];
        string str = "Привет, Мир!";

        fixed (int* p = nums)
        {
            int third = *(p + 2);
            Console.WriteLine(third);
        }

        fixed (char* p = str)
        {
            char forth = *(p + 3);
            Console.WriteLine(forth);
        }
    }

}

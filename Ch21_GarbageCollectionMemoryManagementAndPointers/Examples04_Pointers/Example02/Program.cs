// Операции * и &
unsafe
{
    int* x; // определение указателя
    int y = 10; // определяем переменную

    x = &y; // указатель x теперь указывает на адрес переменной y
    Console.WriteLine(*x); // 10

    y += 20;
    Console.WriteLine(*x); // 30

    *x = 50;
    Console.WriteLine(y); // 50
}

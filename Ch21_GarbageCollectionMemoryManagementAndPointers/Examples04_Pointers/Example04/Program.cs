﻿// Указатель на другой указатель
unsafe
{
    int* x;
    int y = 10;

    x = &y; // указатель x теперь указывает на адрес переменной y
    int** z = &x; // указатель z теперь указывает на адрес, указателя x
    **z += 40; // изменение указателя z повлечет изменение переменной y
    Console.WriteLine(y);
    Console.WriteLine(**z);
}

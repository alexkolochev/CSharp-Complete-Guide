// Указатели на типы и операция ->
/*
 * Указатель может указывать только на те структуры, 
 * которые не имеют полей ссылочных типов 
 * (в том числе полей, которые генерируются компилятором автоматически для автосвойств)
 */
using System.Drawing;

unsafe
{
    Point point = new(0, 0);
    Console.WriteLine(point);
    Point* p = &point;

    p->X = 30;

    // разыменовывание указателя
    (*p).Y = 180;
    Console.WriteLine((*p).Y);

    Console.WriteLine(point);
}

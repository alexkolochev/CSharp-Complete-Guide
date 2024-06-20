// Обобщенные методы

int x = 7;
int y = 25;
Swap(ref x, ref y);
Console.WriteLine($"x={x}; y={y}");

string s1 = "hello";
string s2 = "bye";
Swap(ref s1, ref s2);
Console.WriteLine($"s1={s1}; s2={s2}");

void Swap<T>(ref T x, ref T y)
{
    T temp = x;
    x = y;
    y = temp;
}

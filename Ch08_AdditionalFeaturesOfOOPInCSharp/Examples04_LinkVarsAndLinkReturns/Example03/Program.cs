// Ссылка как результат функции
int a = 5;
int b = 8;
ref int pointer = ref Max(ref a, ref b);
pointer = 34;
Console.WriteLine($"a: {a}; b: {b}");

ref int Max(ref int n1, ref int n2)
{
    if (n1 > n2)
        return ref n1;

    return ref n2;
}

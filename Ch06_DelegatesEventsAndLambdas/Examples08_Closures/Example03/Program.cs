// Применение параметров
var fn = Multiply(5);
Console.WriteLine(fn(5));
Console.WriteLine(fn(6));
Console.WriteLine(fn(7));

Operation Multiply(int n)
{
    int Inner(int m)
    {
        return n * m;
    }

    return Inner;
}

//var multply = (int n) => (int m) => n * m; // сокращенная форма

delegate int Operation(int n);

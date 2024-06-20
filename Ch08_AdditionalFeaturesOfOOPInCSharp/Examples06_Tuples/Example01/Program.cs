// Кортеж как результат метода
var tuple = GetValues();
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);

(int, int) GetValues()
{
    var result = (1, 3);
    return result;
}

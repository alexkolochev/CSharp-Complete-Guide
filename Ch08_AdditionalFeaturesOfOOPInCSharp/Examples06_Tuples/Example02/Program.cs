// Кортеж как результат метода
var tuple = GetValuesData([1, 2, 3, 4, 5, 6, 7]);
Console.WriteLine(tuple.count);
Console.WriteLine(tuple.sum);

(int sum, int count) GetValuesData(int[] numbers)
{
    var result = (sum: 0, count: numbers.Length);

    foreach (var number in numbers)
        result.sum += number;

    return result;
}

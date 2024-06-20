// Возвращение результата
var sum = (int x, int y) => x + y;
int sumResult = sum(4, 5);
Console.WriteLine(sumResult);

Operation multiply = (x, y) => x * y;
int multiplyResult = multiply(4, 5);
Console.WriteLine(multiplyResult);

var subtract = (int x, int y) =>
{
    if (x > y) return x - y;
    return y - x;
};

int result1 = subtract(10, 6);
Console.WriteLine(result1);
int result2 = subtract(-10, 6);
Console.WriteLine(result2);

delegate int Operation(int x, int y);

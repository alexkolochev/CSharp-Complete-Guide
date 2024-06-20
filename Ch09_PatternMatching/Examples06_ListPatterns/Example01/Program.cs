/*
 * Паттерны списков (list pattern) позволяют сопоставлять выражения со списками и массивами.
 * Данный паттерн пока доступен начиная с версии C# 11.
 */

Console.WriteLine(GetNumber(new[] { 1, 2, 3, 4, 5 }));
Console.WriteLine(GetNumber(new[] { 1, 2 }));
Console.WriteLine(GetNumber(new int[] { }));
Console.WriteLine(GetNumber(new[] { 1, 2, 5 }));

List<int> numbers = new List<int> { 1, 2, 3 };
Console.WriteLine(GetNumber2(numbers));

int[] numbers2 = { 1, 2, 3, 4, 5 };
if (numbers2 is [1, 2, 3, 4, 5])
{
    Console.WriteLine("[1, 2, 3, 4, 5]");
}

int GetNumber(int[] values) => values switch
{
[1, 2, 3, 4, 5] => 1,
[1, 2, 3] => 2,
[1, 2] => 3,
[] => 4,
    _ => 5
};

int GetNumber2(List<int> values) => values switch
{
[1, 2, 3, 4, 5] => 1,
[1, 2, 3] => 2,
[1, 2] => 3,
[] => 4,
    _ => 5
};

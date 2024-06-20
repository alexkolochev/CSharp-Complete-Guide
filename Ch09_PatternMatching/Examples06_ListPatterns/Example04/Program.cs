// Получение элементов в переменные
int[] numbers = { 2, 3, 5 };
if (numbers is [var first, var second, .., var last])
{
    Console.WriteLine($"first: {first}, second: {second}  last: {last}");
}

Console.WriteLine(GetData(new[] { 1, 2, 3 }));
Console.WriteLine(GetData(new[] { 2, 4, 6, 8 }));
Console.WriteLine(GetData(new[] { 1, 2 }));

Console.WriteLine(GetSlice(new[] { 2, 3, 4, 5 }));
Console.WriteLine(GetSlice(new[] { 2, 4, 6, 8 }));
Console.WriteLine(GetSlice(new[] { 1, 2, 3, 5 }));
Console.WriteLine(GetSlice(new[] { 1, 2, 3, 4 }));
Console.WriteLine(GetSlice(new int[] { }));

string GetData(int[] values) => values switch
{
[var first, var second, .., var last] => $"First: {first}  Second: {second}  Last: {last}",
[..] => "Array has less than 3 elements"
};

string GetSlice(int[] values) => values switch
{
[2, .. var middle, 5] => $"Middle: {string.Join(", ", middle)}",
[2, .. var end] => $"End: {string.Join(", ", end)}",
[.. var start, 5] => $"Start: {string.Join(", ", start)}",
[.. var all] => $"All: {string.Join(", ", all)}"
};

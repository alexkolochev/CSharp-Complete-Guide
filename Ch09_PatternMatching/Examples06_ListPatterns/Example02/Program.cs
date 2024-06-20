// Подстановка _
Console.WriteLine(GetNumber(new[] { 2, 3, 5 }));
Console.WriteLine(GetNumber(new[] { 2, 4, 6 }));
Console.WriteLine(GetNumber(new[] { 1, 2, 5 }));
Console.WriteLine(GetNumber(new[] { 1, 2, 3 }));
Console.WriteLine(GetNumber(new int[] { }));

int GetNumber(int[] values) => values switch
{
[2, _, 5] => 1,
[2, _, _] => 2,
[_, _, 5] => 3,
[_, _, _] => 4,
    _ => 5
};

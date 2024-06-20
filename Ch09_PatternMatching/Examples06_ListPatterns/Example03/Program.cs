// slice-паттерн
Console.WriteLine(GetNumber(new[] { 2, 5 }));
Console.WriteLine(GetNumber(new[] { 2, 3, 4, 5 }));

Console.WriteLine(GetNumber(new[] { 2 }));
Console.WriteLine(GetNumber(new[] { 2, 3, 4 }));

Console.WriteLine(GetNumber(new[] { 3, 4, 5 }));
Console.WriteLine(GetNumber(new[] { 5 }));

Console.WriteLine(GetNumber(new int[] { }));
Console.WriteLine(GetNumber(new[] { 1 }));
Console.WriteLine(GetNumber(new[] { 1, 2, 3 }));

int GetNumber(int[] values) => values switch
{
[2, .., 5] => 1,
[2, ..] => 2,
[.., 5] => 3,
[..] => 4
};

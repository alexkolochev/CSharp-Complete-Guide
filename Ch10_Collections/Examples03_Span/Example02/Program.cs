// ReadOnlySpan
string text = "Hello, World!";
string worldString = text.Substring(7, 5);
ReadOnlySpan<char> worldSpan = text.AsSpan().Slice(7, 5);
//worldSpan[0] = 'a';
Console.WriteLine(worldSpan[0]);

foreach (var c in worldSpan)
{
    Console.Write(c);
}

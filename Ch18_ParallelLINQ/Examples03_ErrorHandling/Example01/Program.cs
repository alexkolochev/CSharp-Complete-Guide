object[] numbers = [1, 2, 3, 4, 5, "6"];

var squares = from n in numbers.AsParallel()
              let x = (int)n
              select Square(x);

try
{
    squares.ForAll(Console.WriteLine);
}
catch (AggregateException ex)
{
    foreach (var e in ex.InnerExceptions)
        Console.WriteLine(e.Message);
}

int Square(int n) => n * n;

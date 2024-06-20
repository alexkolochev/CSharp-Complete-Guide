// Метод AsParallel
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8];

//var squares = from n in numbers.AsParallel()
//              select Square(n);
var squares = numbers.AsParallel().Select(x => Square(x));

foreach (var n in squares)
    Console.WriteLine(n);

int Square(int n) => n * n;

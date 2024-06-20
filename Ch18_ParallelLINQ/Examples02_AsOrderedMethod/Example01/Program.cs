/*
 * Если в программе предстоят какие-нибудь манипуляции с полученным набором,
 * однако упорядочивание больше не требуется, мы можем применить метод AsUnordered().
 */
int[] numbers = [-2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8];

var squares = from n in numbers.AsParallel().AsOrdered()
              where n > 0
              select Square(n);

var query = from n in squares.AsUnordered()
            where n > 4
            select n;

foreach (var n in query)
    Console.WriteLine(n);

int Square(int n) => n * n;

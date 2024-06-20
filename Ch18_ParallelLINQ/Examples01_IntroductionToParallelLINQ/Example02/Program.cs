// Метод ForAll
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8];

(from n in numbers.AsParallel() select Square(n)).ForAll(Console.WriteLine);

numbers.AsParallel().Select(n => Square(n)).ForAll(Console.WriteLine);

int Square(int n) => n * n;

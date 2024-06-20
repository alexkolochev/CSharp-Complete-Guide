// Максимальное, минимальное и среднее значения
using Example04;

int[] numbers = [1, 2, 3, 4, 10, 34, 55, 66, 77, 88];
int min = numbers.Min();
int max = numbers.Max();
double average = numbers.Average();
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Average: {average}");

Person[] people = [new("Tom", 37), new("Sam", 28), new("Bob", 41)];
int minAge = people.Min(p => p.Age);
int maxAge = people.Max(p => p.Age);
double averageAge = people.Average(p => p.Age);
Console.WriteLine($"Min Age: {minAge}");
Console.WriteLine($"Max Age: {maxAge}");
Console.WriteLine($"Average Age: {averageAge}");

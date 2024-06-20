// Получение суммы
using Example03;

int[] numbers = [1, 2, 3, 4, 10, 34, 55, 66, 77, 88];
int sum = numbers.Sum();
Console.WriteLine(sum);

Person[] people = [new("Tom", 37), new("Sam", 28), new("Bob", 41)];
int sumAge = people.Sum(p => p.Age);
Console.WriteLine(sumAge);

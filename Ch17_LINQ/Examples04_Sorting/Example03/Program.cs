// Сортировка по возрастанию и убыванию
int[] numbers = [3, 12, 4, 10];

//var orderedNumbers = from n in numbers
//                     orderby n descending
//                     select n;
var orderedNumbers = numbers.OrderByDescending(n => n);

foreach (var n in orderedNumbers)
    Console.WriteLine(n);

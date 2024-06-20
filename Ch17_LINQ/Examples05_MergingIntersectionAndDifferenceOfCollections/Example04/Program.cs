// Объединение последовательностей
string[] soft = ["Microsoft", "Google", "Apple"];
string[] hard = ["Apple", "IBM", "Samsung"];

var result = soft.Union(hard);

foreach (var item in result)
    Console.WriteLine(item);

var result2 = soft.Concat(hard);
foreach (var item in result2)
    Console.WriteLine(item);

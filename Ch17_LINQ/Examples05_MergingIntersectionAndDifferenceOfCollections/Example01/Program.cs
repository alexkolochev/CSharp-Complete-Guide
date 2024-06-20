// Разность последовательностей
string[] soft = ["Microsoft", "Google", "Apple"];
string[] hard = ["Apple", "IBM", "Samsung"];

var result = soft.Except(hard);

foreach (var item in result)
    Console.WriteLine(item);

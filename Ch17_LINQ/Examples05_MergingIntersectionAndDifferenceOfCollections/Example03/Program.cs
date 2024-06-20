// Удаление дубликатов
string[] soft = ["Microsoft", "Google", "Apple", "Microsoft", "Google"];

var result = soft.Distinct();

foreach (var item in result)
    Console.WriteLine(item);

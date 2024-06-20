// Метод Aggregate
int[] numbers = [1, 2, 3, 4, 5];
int query1 = numbers.Aggregate((x, y) => x - y);
Console.WriteLine(query1);

int query2 = numbers.Aggregate((x, y) => x + y);
Console.WriteLine(query2);

string[] words = ["Gaudeamus", "igitur", "Juvenes", "dum", "sumus"];
var sentnce = words.Aggregate("Text:", (first, next) => $"{first} {next}");
Console.WriteLine(sentnce);

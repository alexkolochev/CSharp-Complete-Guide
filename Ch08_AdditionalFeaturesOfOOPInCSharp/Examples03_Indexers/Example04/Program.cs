// Перегрузка индексаторов
using Example04;

var microsoft = new Company([new("Tom"), new("Bob"), new("Sam")]);

Console.WriteLine(microsoft[0].Name);
Console.WriteLine(microsoft["Bob"].Name);

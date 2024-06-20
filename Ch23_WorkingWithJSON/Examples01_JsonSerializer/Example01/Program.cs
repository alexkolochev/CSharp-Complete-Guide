/*
 * Некоторые замечания по сериализации/десериализации:
 * Объект, который подвергается десериализации, должен иметь либо конструктор без параметров, 
 * либо конструктор, для всех параметров которого в десериализуемом json-объекте есть значения 
 * (соответствие между параметрами конструктора и свойствами json-объекта устанавливается на основе названий, 
 * причем регистр не играет значения).
 * Сериализации подлежат только публичные свойства объекта (с модификатором public).
 */
using Example01;
using System.Text.Json;

Person tom = new("Tom", 37);
string json = JsonSerializer.Serialize(tom);
Console.WriteLine(json);
Person? restoredPerson = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(restoredPerson?.Name);

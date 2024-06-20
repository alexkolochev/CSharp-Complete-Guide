/*
 * Как известно, неотъемлемыми компонентами бутерброда являются хлеб и масло.
 * Допустим, у нас есть следующие классы: Bread, Butter и Sandwich.
 * Добавьте в один из классов оператор сложения, чтобы при объединении хлеба и масла получался бутерброд, 
 * и, тем самым, компилировался и выполнялся без ошибок следующий код:
 */
using Exercise02;

Bread bread = new Bread { Weight = 80 };
Butter butter = new Butter { Weight = 20 };
Sandwich sandwich = bread + butter;
Console.WriteLine(sandwich.Weight);

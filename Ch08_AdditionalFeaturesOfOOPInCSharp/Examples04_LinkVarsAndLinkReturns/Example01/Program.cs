// Переменная-ссылка
int x = 5;
ref int xRef = ref x;
Console.WriteLine(x);
xRef = 125;
Console.WriteLine(x);
x = 625;
Console.WriteLine(xRef);

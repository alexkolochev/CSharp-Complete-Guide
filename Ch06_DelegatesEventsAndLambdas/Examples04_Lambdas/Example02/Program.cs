// Параметры лямбды
//Operation sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
var sum = (int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
sum(1, 2);
sum(22, 14);

PrintHandler print = message => Console.WriteLine(message);
print("Hello");
print("Welcome");

var welcome = (string message = "Hello") => Console.WriteLine(message);
welcome("Hello, World!");
welcome();

delegate void Operation(int x, int y);
delegate void PrintHandler(string message);

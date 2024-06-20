// Добавление и удаление действий в лямбда-выражении
var hello = () => Console.WriteLine("METANIT.COM");
var message = () => Console.Write("Hello, ");
message += hello;
message += Print;
message();

Console.WriteLine("----------");

message -= Print;
message -= hello;
message?.Invoke();

void Print() => Console.WriteLine("Welcome to C#");

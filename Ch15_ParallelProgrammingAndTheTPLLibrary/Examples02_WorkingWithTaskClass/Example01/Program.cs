// Вложенные задачи
var outer = Task.Factory.StartNew(() =>
{
    Console.WriteLine("Outer task starting...");
    var inner = Task.Factory.StartNew(() =>
    {
        Console.WriteLine("Inner task starting...");
        Thread.Sleep(2000);
        Console.WriteLine("Inner task finished.");
    }, TaskCreationOptions.AttachedToParent); // Если необходимо, чтобы вложенная задача выполнялась как часть внешней
});
outer.Wait();
Console.WriteLine("End of Main");

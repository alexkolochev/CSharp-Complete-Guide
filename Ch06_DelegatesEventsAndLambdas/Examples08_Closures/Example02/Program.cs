// Реализация с помощью лямбда-выражений
var outerFn = () =>
{
    int x = 10;
    var innerFn = () => Console.WriteLine(++x);
    return innerFn;
};

var fn = outerFn();
fn();
fn();
fn();

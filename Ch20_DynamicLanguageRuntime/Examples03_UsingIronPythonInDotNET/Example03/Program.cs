// Вызов функций из IronPython
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

int number = 5;

ScriptEngine engine = Python.CreateEngine();
ScriptScope scope = engine.CreateScope();
engine.ExecuteFile("hello.py", scope);
dynamic square = scope.GetVariable("square");
dynamic result = square(number);
Console.WriteLine(result);

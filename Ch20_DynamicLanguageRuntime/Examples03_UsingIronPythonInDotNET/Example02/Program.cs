// ScriptScope
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

int y = 22;

ScriptEngine engine = Python.CreateEngine();
ScriptScope scope = engine.CreateScope();
scope.SetVariable("y", y);
engine.ExecuteFile("hello.py", scope);
dynamic x = scope.GetVariable("x");
dynamic z = scope.GetVariable("z");
Console.WriteLine($"{x} + {y} = {z}");

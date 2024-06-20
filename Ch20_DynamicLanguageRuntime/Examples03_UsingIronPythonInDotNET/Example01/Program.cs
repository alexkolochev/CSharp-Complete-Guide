using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

ScriptEngine engine = Python.CreateEngine();
engine.Execute("print('hello, world')");
engine.ExecuteFile("hello.py");

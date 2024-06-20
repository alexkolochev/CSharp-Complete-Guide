// Лямбда-выражение как результат метода
using Example06;

Operation operation = SelectOperation(OperationTypeE.Add);
Console.WriteLine(operation(10, 4));

operation = SelectOperation(OperationTypeE.Subtract);
Console.WriteLine(operation(10 ,4));

operation = SelectOperation(OperationTypeE.Multiply);
Console.WriteLine(operation(10 ,4));

Operation SelectOperation(OperationTypeE opType)
{
	switch (opType)
	{
		case OperationTypeE.Add: return (x, y) => x + y;
		case OperationTypeE.Subtract: return (x, y) => x - y;
		default: return (x, y) => x * y;
    }
}

delegate int Operation(int x, int y);

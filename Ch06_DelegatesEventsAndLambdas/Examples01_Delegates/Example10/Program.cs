// Возвращение делегатов из метода
using Example10;

Operation operation = SelectOperation(OperationTypeE.Add);
Console.WriteLine(operation(10, 4));

operation = SelectOperation(OperationTypeE.Subtract);
Console.WriteLine(operation(10, 4));

operation = SelectOperation(OperationTypeE.Multiply);
Console.WriteLine(operation(10, 4));

Operation SelectOperation(OperationTypeE opType)
{
    switch (opType)
    {
        case OperationTypeE.Add:
            return Add;
        case OperationTypeE.Subtract:
            return Subtract;
        default:
            return Multiply;
    }
}

int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

delegate int Operation(int x, int y);

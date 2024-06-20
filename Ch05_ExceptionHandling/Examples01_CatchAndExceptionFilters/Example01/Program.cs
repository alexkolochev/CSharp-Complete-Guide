// Фильтры исключений
int x = 0;
int y = 1;

try
{
    int result1 = x / y;
	int result2 = y / x;
}
catch (DivideByZeroException) when (y == 0)
{
    Console.WriteLine("y не должен быть равен 0");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}

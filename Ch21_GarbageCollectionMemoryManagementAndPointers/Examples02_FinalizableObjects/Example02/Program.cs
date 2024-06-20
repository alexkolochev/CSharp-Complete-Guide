// Интерфейс IDisposable
using Example02;

Test();

void Test()
{
    Person? tom = null;
    
    try
    {
        tom = new("Tom");
    }
    finally
    {
        tom?.Dispose();
    }
}

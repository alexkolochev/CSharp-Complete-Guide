using Example01;

Test();

long totalMemory = GC.GetTotalMemory(false);
Console.WriteLine(totalMemory);

GC.Collect();
// GC.Collect(1, GCCollectionMode.Forced); // немедленная сборка мусора вплоть до первого поколения объектов
GC.WaitForPendingFinalizers();

void Test()
{
    Person tom = new("Tom");
    Console.WriteLine(tom.Name);
}

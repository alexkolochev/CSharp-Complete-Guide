using Example01;

Test();

void Test()
{
	using (Person tom = new("Tom"))
	{
        Console.WriteLine($"Name: {tom.Name}");
    }
}

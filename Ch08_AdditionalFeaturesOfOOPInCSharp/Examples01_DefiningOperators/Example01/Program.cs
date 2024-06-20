using Example01;

Counter counter1 = new Counter { Value = 23 };
Counter counter2 = new Counter { Value = 45 };
bool result = counter1 > counter2;
Console.WriteLine(result);

Counter counter3 = counter1 + counter2;
Console.WriteLine(counter3.Value);

using Example01;

Counter counter1 = new Counter { Seconds = 23 };
int x = (int)counter1;
Console.WriteLine(x);

Counter counter2 = x;
Console.WriteLine(counter2.Seconds);

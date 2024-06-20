using Example02;

Counter counter1 = new Counter { Seconds = 115 };

Example02.Timer timer = counter1;
Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}");

Counter counter2 = (Counter)timer;
Console.WriteLine(counter2.Seconds);

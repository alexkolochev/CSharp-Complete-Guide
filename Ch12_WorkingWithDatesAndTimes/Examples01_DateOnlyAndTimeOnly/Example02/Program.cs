// TimeOnly
TimeOnly time1 = new TimeOnly(4, 30);
Console.WriteLine(time1);

TimeOnly time2 = new TimeOnly(14, 23, 30);
Console.WriteLine(time2);
Console.WriteLine(time2.Hour);
Console.WriteLine(time2.Minute);
Console.WriteLine(time2.Second);

TimeOnly time = TimeOnly.Parse("06:33:22");
Console.WriteLine(time);
time = time.AddHours(1);
time = time.AddMinutes(-23);
Console.WriteLine(time.ToShortTimeString());
Console.WriteLine(time.ToLongTimeString());

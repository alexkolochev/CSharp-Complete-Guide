// DateOnly
using System.Globalization;

DateOnly julianDate = new DateOnly(2024, 6, 9, new JulianCalendar());
Console.WriteLine(julianDate);

DateOnly now = new DateOnly(2024, 6, 9);
Console.WriteLine(now.Day);
Console.WriteLine(now.DayNumber);
Console.WriteLine(now.DayOfWeek);
Console.WriteLine(now.DayOfYear);
Console.WriteLine(now.Month);
Console.WriteLine(now.Year);

now = DateOnly.Parse("09.05.2024");
Console.WriteLine(now);
now = now.AddDays(1);
now = now.AddMonths(4);
now = now.AddYears(-1);
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongDateString());

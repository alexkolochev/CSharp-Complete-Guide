using Example01;

foreach (var n in 5) Console.WriteLine(n);
foreach (var n in -5) Console.WriteLine(n);

var people = new Person[]
{
    new("Tom"),
    new("Bob"),
    new("Sam")
};
var microsoft = new Company(people);

foreach (Person employee in microsoft)
{
    Console.WriteLine(employee.Name);
}

static class Int32Extension
{
    public static IEnumerator<int> GetEnumerator(this int number)
    {
        int k = (number > 0) ? number : 0;
        for (int i = number - k; i <= k; i++)
            yield return i;
    }
}

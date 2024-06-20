using Example01;

Person<int> tom = new Person<int>(546, "Tom");
Person<string> bob = new Person<string>("abc123", "Bob");

int tomId = tom.Id;
string bobId = bob.Id;

Console.WriteLine(tomId);
Console.WriteLine(bobId);

Company<Person<int>> microsoft = new Company<Person<int>>(tom);
Console.WriteLine(microsoft.CEO.Id);
Console.WriteLine(microsoft.CEO.Name);

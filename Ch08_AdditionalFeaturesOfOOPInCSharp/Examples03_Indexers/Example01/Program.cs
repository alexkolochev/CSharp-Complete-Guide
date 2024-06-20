using Example01;

var microsoft = new Company([new Person("Tom"), new Person("Sam"), new Person("Alice")]);

Person firstPeson = microsoft[0];
Console.WriteLine(firstPeson.Name);
microsoft[0] = new Person("Mike");
Console.WriteLine(microsoft[0].Name);

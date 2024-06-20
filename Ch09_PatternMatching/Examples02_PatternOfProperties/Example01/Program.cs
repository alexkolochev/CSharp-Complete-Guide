// Паттерн свойств позволяет сравнивать со значениями определенных свойств объекта.
using Example01;

Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
string message = GetMessage(pierre);
Console.WriteLine(message);

Person tomas = new Person { Language = "german", Status = "admin", Name = "Tomas" };
Console.WriteLine(GetMessage(tomas));

Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo" };
Console.WriteLine(GetMessage(pablo));

Console.WriteLine(GetMessage(null));

/*
void SayHello(Person person)
{
    if (person is Person { Language: "french" })
    {
        Console.WriteLine("Salut");
    }
    else
    {
        Console.WriteLine("Hello");
    }
}
*/

void SayHello(Person person)
{
    if (person is Person { Language: "english", Status: "admin" })
    {
        Console.WriteLine("Hello, admin");
    }
    else if (person is Person { Language: "french" })
    {
        Console.WriteLine("Salut");
    }
    else
    {
        Console.WriteLine("Hello");
    }
}

/*
string GetMessage(Person? person) => person switch
{
    { Language: "english" } => "Hello",
    { Language: "german", Status: "admin" } => "Hallo, admin!",
    { Language: "french" } => "Salut!",
    { } => "undefined",
    null => "null"
};
*/

string GetMessage(Person? person) => person switch
{
    { Language: "german", Status: "admin" } => "Hallo, admin!",
    { Language: "french", Name: var name } => $"Salut, {name}!",
    { Language: var lang } => $"Unknown language: {lang}",
    null => "null"
};

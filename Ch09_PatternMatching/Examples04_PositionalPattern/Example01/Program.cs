// Позиционный паттерн применяется к типу, у которого определен метод деконструктора.
using Example01;

MessageDetails details1 = new MessageDetails { Language = "english", DateTime = "evening", Status = "user" };
string message = GetWelcome(details1);
Console.WriteLine(message);

MessageDetails details2 = new MessageDetails { Language = "french", DateTime = "morning", Status = "admin" };
message = GetWelcome(details2);
Console.WriteLine(message);

MessageDetails details3 = new MessageDetails { Language = "chinese", DateTime = "night", Status = "moderator" };
message = GetWelcome(details3);
Console.WriteLine(message);

/*
string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    _ => "Здрасьть"
};
*/

string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    (var lang, var datetime, var status) => $"{lang} not found, {datetime} unknown, {status} undefined"
};
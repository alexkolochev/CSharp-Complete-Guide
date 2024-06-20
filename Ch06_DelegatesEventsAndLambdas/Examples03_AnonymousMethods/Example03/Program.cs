MessageHandler handler = delegate
{
    Console.WriteLine("Анонимный метод");
};
handler("Hello, World!");

delegate void MessageHandler(string message);

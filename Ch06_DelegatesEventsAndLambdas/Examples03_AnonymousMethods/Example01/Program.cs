MessageHandler handler = delegate (string mes)
{
    Console.WriteLine(mes);
};
handler("Hello, World!");

delegate void MessageHandler(string message);

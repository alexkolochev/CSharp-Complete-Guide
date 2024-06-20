namespace Example01
{
    internal interface IMessenger<out T>
    {
        T WriteMessage(string text);
    }
}

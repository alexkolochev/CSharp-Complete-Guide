namespace Example03
{
    internal interface IMessenger<in T, out K>
    {
        void SendMessage(T message);
        K WriteMessage(string text);
    }
}

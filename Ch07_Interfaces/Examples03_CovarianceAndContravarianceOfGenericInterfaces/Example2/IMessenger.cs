namespace Example02
{
    internal interface IMessenger<in T>
    {
        void SendMessage(T message);
    }
}

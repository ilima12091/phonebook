namespace Library
{
    public interface IMessageChannel
    {
        void Send(IMessage message);
        void PerformMessage(string message, string from, Contact to);
    }
}
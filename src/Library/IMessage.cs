namespace Library
{
    public interface IMessage
    {
        string Text { get; set; }
        
        string From { get; }

        string To { get; }
    }
}
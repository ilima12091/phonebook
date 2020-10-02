namespace Library
{
    public class TwMessage : IMessage
    {
        public string Text { get; set; }

        public string From { get; }
        public string To { get; }

        public TwMessage(string text, string from, string to)
        {
            this.Text = text;
            this.From = from;
            this.To = to;
        }
    }
}
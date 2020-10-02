namespace Library
{
    public class WhatsAppMessage : IMessage
    {
        public string Text { get; set; }

        public string From { get; }
        public string To { get; }

        public WhatsAppMessage(string text, string from, string to)
        {
            this.Text = text;
            this.From = from;
            this.To = to;
        }
    }
}
using System;
using TwitterUCU;

namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
        public void Send(IMessage message)
        {
            string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
            string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
            string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
            string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("New Employee 2! ",@"bill2.jpg"));
            var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitterDirectMessage.SendMessage(((TwMessage) message).Text, ((TwMessage) message).To));
        }

        public void PerformMessage(string message, string from, Contact to)
        {
            TwMessage tMessage = new TwMessage(message, from, to.TwitterId);
            Send(tMessage);
        }
    }
}
using System;
using WhatsAppApiUCU;

namespace Library
{
    public class WhatsappChannel : IMessageChannel
    {
        public void Send(IMessage message)
        {
            const string accountSid = "AC52493b284c82ba2c6b196ef82e412576";
            const string authToken = "<INGRESAR EL TOKEN>"; // No dejamos el token por lo que pidieron ustedes, si lo ingresan va a funcionar

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send(((WhatsAppMessage) message).To, ((WhatsAppMessage) message).Text);
            Console.WriteLine(sid);
        }
    
        public void PerformMessage(string message, string from, Contact to)
        {
            WhatsAppMessage tMessage = new WhatsAppMessage(message, from, to.Phone);
            Send(tMessage);
        }

    }
}
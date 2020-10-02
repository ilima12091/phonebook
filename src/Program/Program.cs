using System;
using Library;

namespace Program
{
    class Program
    {
       static void Main(string[] args)
        {
            Contact owner = new Contact("grupo3");
            Phonebook phonebook = new Phonebook(owner);

            Contact nacho = phonebook.AddContact("nacho");
            nacho.TwitterId = "1203382413524688896";
            nacho.Phone = "+59891026239";

            Contact jero = phonebook.AddContact("jero");
            jero.Phone = "+59899382129";

            Contact rodri = phonebook.AddContact("rodri");
            rodri.Phone="+59895032980";

            IMessageChannel channel = new TwitterChannel();
            //channel = new WhatsappChannel();
            phonebook.SendMessage(new string[1] {"nacho"}, "Prueba twitter", channel);

        }
    }
}

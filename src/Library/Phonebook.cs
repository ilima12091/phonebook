using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public Contact AddContact(string name)
        {
            Contact contact = new Contact(name);
            if(!this.persons.Contains(contact))
            {
                this.persons.Add(contact);
            }
            return contact;
        }

        public void RemoveContact(string[] name)
        {
            List<Contact> peopleToRemove = Search(name);
            foreach(Contact c in peopleToRemove)
            {
                this.persons.Remove(c);
            }
        }

        public void SendMessage(string[] name, string message, IMessageChannel channel)
        {
            List<Contact> peopleToSend = Search(name);
            foreach(Contact c in peopleToSend)
            {
                channel.PerformMessage(message, this.Owner.Name, c);
            }
        }
    }
}
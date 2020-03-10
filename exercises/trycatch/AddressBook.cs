using System;
using System.Collections.Generic;

namespace trycatch
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts { get; set; }

        public AddressBook()
        {
            Contacts = new Dictionary<string, Contact>();
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            return Contacts[email];
        }
    }
}
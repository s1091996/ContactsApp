﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Models
{
    public class ContactsRepository
    {
        public static List<ContactItem> contactItems = new List<ContactItem>()
        {
            new ContactItem(){Id = 1, Name = "John Doe", Number = "555-555-5555", Email = "a@gmail.com"},
            new ContactItem(){Id = 2, Name = "Jane Doe", Number = "555-555-5555", Email = "b@gmail.com"},
            new ContactItem(){Id = 3, Name = "John Smith", Number = "555-555-5555", Email = "c@gmail.com"},
            new ContactItem(){Id = 4, Name = "John Doe", Number = "555-555-5555", Email = "d@gmail.com"},
            new ContactItem(){Id = 5, Name = "Jane Doe", Number = "555-555-5555", Email = "e@gmail.com"},
            new ContactItem(){Id = 6, Name = "John Smith", Number = "555-555-5555", Email = "f@gmail.com"},
            new ContactItem(){Id = 7, Name = "John Doe", Number = "555-555-5555", Email = "g@gmail.com"},
            new ContactItem(){Id = 8, Name = "Jane Doe", Number = "555-555-5555", Email = "h@gmail.com"},
            new ContactItem(){Id = 9, Name = "John Smith", Number = "555-555-5555", Email = "i@gmail.com"},
            new ContactItem(){Id = 10, Name = "John Doe", Number = "555-555-5555", Email = "j@gmail.com"},
            new ContactItem(){Id = 11, Name = "Jane Doe", Number = "555-555-5555", Email = "k@gmail.com"},
            new ContactItem(){Id = 12, Name = "John Smith", Number = "555-555-5555", Email = "l@gmail.com"},
            new ContactItem(){Id = 13, Name = "John Doe", Number = "555-555-5555", Email = "m@gmail.com"},
            new ContactItem(){Id = 14, Name = "Jane Doe", Number = "555-555-5555", Email = "n@gmail.com"},
            new ContactItem(){Id = 15, Name = "John Smith", Number = "555-555-5555", Email = "o@gmail.com"}
        };
       
        
        public static void AddContact(ContactItem contact)
        {
            if (contact != null)
            {
                var checkEmail = contactItems.FirstOrDefault(c => c.Email.Equals(contact.Email));
                if (checkEmail != null)
                {
                    Shell.Current.DisplayAlert("Error", "Email already exists!", "OK");
                }
                else
                {
                    int maxId = contactItems.Max(c => c.Id);
                    contact.Id = maxId + 1;
                    contactItems.Add(contact);
                    Shell.Current.DisplayAlert("Success", "Contact added done!", "OK");
                }
            }
        }

        //Update
        public static void UpdateContact(ContactItem contact)
        {
            if (contact != null)
            {
                contactItems[contact.Id - 1] = contact;
                Shell.Current.DisplayAlert("Success", "Contact updated done!", "OK"); 
            }
        }


        //Delete
        public static void DeleteContact(int id)
        {
            var contactToDelete = contactItems.FirstOrDefault(c => c.Id == id);
            if (contactToDelete != null)
            {
                contactItems.Remove(contactToDelete);
                Shell.Current.DisplayAlert("Success", "Contact deleted done!", "OK");
            }
        }
    }
}

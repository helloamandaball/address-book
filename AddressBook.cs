using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        // Hint: For the address book's list of contacts, the easiest and most efficient way to structure your data is a dictionary with the person's email address as the key and their contact as a value.
        //_contactList is the name of the Dictionary
        private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();
        //<string, Contact> are the type parameters (key/value pair), so keys are the strings, and value would be Contact. So since we want the key to be email... we want to pass it into the params? Or is email a property?
        public void AddContact(Contact contactParam) //"Contact" is the type and "contact" is the parameter
        {
            //Add try/catch code here:
            try
            {
            _contactList.Add(contactParam.Email, contactParam); //contactParam.Email can also be done as a bracket notation _contactList[Email]?? or is it contactParam[Email]??
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Unable to add {contactParam.Email} because this contact already exists!");
            }
        }

        //Goes into the Contact and pulls out a contact with a matching key email (the string). It is returning an object, we use "Contact" in stead of something like void. 
        public Contact GetByEmail(string email)
        {
            return _contactList[email];
        }
    }
}
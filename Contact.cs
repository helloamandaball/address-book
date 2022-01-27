using System;
using System.Collections.Generic;

namespace AddressBook
{
    // Reference Employee code bit, Line 48, from the TryCatch example in Chapter 14.
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string FullName
        {
            get {
                return FirstName + LastName;
            }
        }
    }
}
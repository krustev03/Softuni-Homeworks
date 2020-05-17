
using System;
using Phonebook.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phonebook.Data.Models;

namespace Phonebook.Data
{
    public class DataAcess
    {
        static DataAcess()
        {
            Contacts = new List<Contact>();
        }
        public static List<Contact> Contacts { get; set; }
    }
}

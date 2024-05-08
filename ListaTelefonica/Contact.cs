using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
    internal class Contact
    {
        string name;
        List<string> phoneNumbers;
        Address address;
        string email;
        public Contact(string name, List<string> numbers, Address address, string email)
        {
            this.name = name;
            this.phoneNumbers = numbers;
            this.address = address;
            this.email = email;
            
        }

        public override string? ToString()
        {
            string numbers = "";
            foreach (var item in phoneNumbers)
            {
                numbers += item + "-";
            }
            string s;

            s = $"{name};{numbers};{address.ToString()};{email}";

            return s;
        }
    }
}

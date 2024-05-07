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
        PhoneList phoneNumbers;
        Address address;
        string email;
        Contact next;
        public Contact(string name, PhoneList phoneNumbers, Address address, string email)
        {
            this.name = name;
            this.phoneNumbers = phoneNumbers;
            this.address = address;
            this.email = email;
            this.next = null;
        }

        public void setNext(Contact c)
        {
            next = c;
        }
        public Contact getNext()
        {
            return next;
        }
        public void PrintContact()
        {
            Console.WriteLine("Nome: " + name);
            Console.WriteLine("E-mail: " + email);
            Console.WriteLine("Números telefônicos: ");
            phoneNumbers.PrintList();
            Console.WriteLine("Endereço");
            Console.WriteLine(address.ToString());

        }


    }
}

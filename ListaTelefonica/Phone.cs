using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
    internal class Phone
    {
        string phoneNumber;
        Phone? Next;
        public Phone(string number)
        {
            phoneNumber = number;
            Next = null;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
       
        public void setNext(Phone p)
        {
            this.Next = p;
        }
        public Phone getNext()
        {
            return this.Next;
        }
    }
}

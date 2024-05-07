using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
    internal class PhoneList
    {
        Phone head;
        Phone tail;

        bool IsEmpty()
        {
            return head == null && tail == null;
        }
        public void Add(Phone phone)
        {
            if (IsEmpty())
            {
                tail = head = phone;
            }
            else
            {
                Phone aux = tail;
                aux.setNext(phone);
                tail = phone;
            }
        }
        public void Remove(string phone)
        {
            if (!IsEmpty())
            {
                if (phone.Equals(head.getPhoneNumber()))
                    if (head == tail)
                        tail = head = null;
                    else
                        head = head.getNext();

                Phone current = head;
                Phone previous = head;
                bool find;
                do
                {
                    find = phone.Equals(current.getPhoneNumber());
                    if (find)
                    {
                        previous.setNext(current.getNext());
                        if (previous.getNext() == null)
                            tail = previous;
                    }
                    else
                    {
                        previous = current;
                        current = current.getNext();
                    }

                } while (!find && current != null);
            }
        }

        public void PrintList()
        {
            Phone aux = head;
            do
            {
                Console.WriteLine(aux.getPhoneNumber());
                aux = aux.getNext();
            } while (aux != null);
        }

    }
}

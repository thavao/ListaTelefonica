using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
	internal class Contact
	{
		public string Name { get; set; }
		public List<string> PhoneNumbers { get; set; }
		public Address Address { get; set; }
		public string Email { get; set; }

		public Contact(string name, List<string> phoneNumbers, Address address, string email)
		{
			Name = name;
			PhoneNumbers = phoneNumbers;
			Address = address;
			Email = email;
		}

		public override string? ToString()
		{
			string numbers = "";
			foreach (var item in PhoneNumbers)
			{
				numbers += item + "-";
			}
			numbers = numbers.TrimEnd('-');
			string s;

			s = $"{Name};{numbers};{Address.ToString()};{Email}";

			return s;
		}
	}
}

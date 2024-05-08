using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
    internal class Address
    {
        string city;
        string street;
        string state;
        string number;
        string CEP;
        string neighborhood;
        public Address(string city, string street, string state, string number, string neighborhood, string CEP)
        {
            this.city = city;
            this.street = street;
            this.state = state;
            this.number = number;
            this.neighborhood = neighborhood;
            this.CEP = CEP;
        }

        public override string? ToString()
        {
            //return $"Cidade: {this.city} - {this.state}\nBairro: {this.neighborhood}, Rua: {street}, N:{number}\nCEP: {this.CEP}";
            return $"{this.city};{this.street};{this.state};{this.number};{this.neighborhood};{this.CEP}";
        }
    }
}

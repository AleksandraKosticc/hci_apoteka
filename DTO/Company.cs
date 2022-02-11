using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DTO
{
    class Company
    {
        public int IdProizvodjac { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
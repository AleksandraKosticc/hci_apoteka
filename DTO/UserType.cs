using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DTO
{
    class UserType
    {
        public int IdKorisnikVrsta { get; set; }
        public string NazivKorisnikVrsta { get; set; }
        public string Opis { get; set; }

        public override string ToString()
        {
            return NazivKorisnikVrsta;
        }
    }
} 
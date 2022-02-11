using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DTO
{
    class Employee
    {
        public int IdKorisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Email { get; set; }
        public string AdresaStanovanja { get; set; }
        public UserType UserType { get; set; }
        public string Slika { get; set; }
    }
}
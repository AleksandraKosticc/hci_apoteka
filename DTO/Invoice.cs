using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DTO
{
    class Invoice
    {
        public int IdFaktura { get; set; }
        public System.DateTime DatumIzdavanja { get; set; }
        public decimal IznosRacuna { get; set; }
        public string IdKorisnika { get; set; }
        public int IdProizvodjac { get; set; }
        public Company Company { get; set; }
        public Employee Employee { get; set; }
    }
}
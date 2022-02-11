using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DTO
{
    class Bill
    {
        public int IdRacuna { get; set; }
        public double UkupanIznos { get; set; }
        public string IdKorisnika { get; set; }
        public Employee Employee { get; set; }
    }
}
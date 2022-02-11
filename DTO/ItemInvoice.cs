using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DTO
{
    class ItemInvoice
    {
        public int Barkod { get; set; }
        public int Kolicina { get; set; }
        public double CijenaStavke { get; set; }      
    }
}
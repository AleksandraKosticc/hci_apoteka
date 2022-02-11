using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DTO
{
    class Medicine
    {
        public int Barkod { get; set; }
        public string NazivArtikla { get; set; }
        public int Zaliha { get; set; }
        public string Doza { get; set; }
        public string Oblik { get; set; }
        public double NabavnaCijena { get; set; }
        public double ProdajnaCijena { get; set; }
        public int IdProizvodjaca { get; set; }
        public Company Company { get; set; }
        public string SlikaArtikla { get; set; }


        public override string ToString()
        {
            return NazivArtikla;
        }
    }
}
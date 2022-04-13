using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopisArtiklaProject
{
    internal class Artikl
    {
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public int Cijena  { get; set; }

        public Artikl(string naziv, int kolicina, int cijena)
        {
            Naziv = naziv;
            Kolicina = kolicina;
            Cijena = cijena;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlubLib
{
    public class Nogometas : IOsoba
    {
        
        public PozicijaEnum.Pozicija Pozicija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ID_Kluba { get; set; }
        public int ID_Tima { get; set; }
        public Nogometas(string ime, string prezime,int id, PozicijaEnum.Pozicija pozicija)
        {
            this.Pozicija = pozicija;
            ID_Kluba = id;
            Ime = ime;
            Prezime = prezime;
            ID_Tima = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznicaLib
{
    public class Autor : IPretraga
    {
       
        public string Ime { get; set; }
        public string Prezime { get; set; }
        private string email { get; set; }

        public Autor(string ime, string prezime, string _email)
        {
            Ime = ime;
            Prezime = prezime;
            email = _email;
        }
        public string Ispis()
        {
            return this.Ime +  " " + this.Prezime +"\r\n";
        }

        public bool Usporedi(string kljucnaRijec)
        {
            if (this.Ime.ToLower() == kljucnaRijec.ToLower() || this.Prezime.ToLower() == kljucnaRijec.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}

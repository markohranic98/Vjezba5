using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznicaLib
{
    public class Knjiga : IPretraga
    {
        public string Naziv { get; set; }
        public string Godina { get; set; }
        public int Izdanje { get; set; }
        public List<IPretraga> Autori = new List<IPretraga>();

        public void DodajAutora (Autor autor)
        {
            Autori.Add(autor);
        }

        public void UkloniAUtora (Autor autor)
        {
            Autori.Remove(autor);
        }

        public bool Usporedi(string kljucnaRijec)
        {
            if (this.Naziv.ToLower() == kljucnaRijec.ToLower())
            {
                return true;
            }
            return false;
        }

        public string Ispis()
        {
            return this.Naziv + "\r\n";
        }
    }
}

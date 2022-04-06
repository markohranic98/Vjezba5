using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteData
{
    internal class UvozniArtikl : IArtikl
    {
        public string Ime { get; set; }
        public int Cijena { get; set; }
        public int Kolicina { get; set; }
        public DateTime DatumUvoza { get; set; }

        public UvozniArtikl(string ime, int cijena,int kolicina)
        {
            if (kolicina < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(kolicina));
            }
            Ime = ime;
            Cijena = cijena;
            Kolicina = kolicina;
            DatumUvoza = DateTime.Now;
        }

        public void DodajKolicinu()
        {
            if (this.Kolicina >= 0)
            {
                this.Kolicina++;
            }

        }

        public void MakniKolicinu()
        {
            if (this.Kolicina > 0)
            {
                this.Kolicina--;
            }
        }
    }
}

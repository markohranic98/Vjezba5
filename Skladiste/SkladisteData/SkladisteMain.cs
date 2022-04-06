using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteData
{
    public class SkladisteMain
    {
        public List<IArtikl> Artikli = new List<IArtikl>();

        public SkladisteMain()
        {
            this.Artikli.Add(new UvozniArtikl("testnipodatak", 5, 5));
            this.Artikli.Add(new UvozniArtikl("testnipodatak2", 4, 5));
            this.Artikli.Add(new UvozniArtikl("testnipodatak3", 5, 0));
            this.Artikli.Add(new UvozniArtikl("testnipodatak4", 5, 3));
            this.Artikli.Add(new UvozniArtikl("testnipodatak5", 5, 11));
            this.Artikli.Add(new UvozniArtikl("testnipodatak6", 5, 16));
            this.Artikli.Add(new UvozniArtikl("testnipodatak7", 5, 331));
        }

        public List<IArtikl> DohvatiARtikle()
        {
            return this.Artikli;
        }

        public void DodajDomaci(string ime, int cijena, int kolicina)
        {

            this.Artikli.Add(new DomaciProizvodi(ime,cijena,kolicina));

        }

        public void DodajUvezeno(string ime,int cijena, int kolicina)
        {
            this.Artikli.Add(new UvozniArtikl(ime, cijena, kolicina));
        }

    }
}

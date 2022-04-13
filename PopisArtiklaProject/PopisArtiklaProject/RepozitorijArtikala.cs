using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopisArtiklaProject
{
    internal class RepozitorijArtikala
    {
        public static List<Artikl> Artikli = new List<Artikl>();

        public RepozitorijArtikala()
        {
            
        }

        public void DodajArtikl(string naziv, int cijena, int kolicina)
        {
            Artikli.Add(new Artikl(naziv ,cijena,kolicina));
            Artikli.Sort((x, y) => x.Cijena.CompareTo(y.Cijena));
        }

        public List<Artikl> DohvatiListuArtikla()
        {
            return Artikli;
        }

        public Artikl DohvatiArtikl(string naziv)
        {
            return Artikli.Find(x => x.Naziv == naziv);
        }

        public void ObrisiArtikl(Artikl artikl)
        {
            Artikli.Remove(artikl);
        }
        public int NapraviSumu()
        {
            return Artikli.Sum(x => x.Kolicina * x.Cijena);
        }
    }
}

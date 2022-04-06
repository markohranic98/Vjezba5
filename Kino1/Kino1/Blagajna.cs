using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino1
{
    internal class Blagajna
    {
        public List<Karta> ProdaneKarte = new List<Karta>();

        public void Prodajkartu(Projekcija projekcija, Sjedalo sjedalo)
        {
            if(ProdaneKarte.Find(x=>x.OdabranoSjedalo == sjedalo && x.OdabranaProjekcija == projekcija) == null)
            {
                ProdaneKarte.Add(new Karta(projekcija, sjedalo));
            }
        }
    }
}

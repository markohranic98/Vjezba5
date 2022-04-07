using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretninaž
{
    internal class Agencija
    {
        public List<Zgrada> Zgrade = new List<Zgrada>();
        public string Naziv { get; set; }

        public void ProdajProstor(string oznakaProstora,string kupac)
        {
            foreach (var item in Zgrade)
            {
                foreach (var item2 in item.Katovi)
                {
                    var prostor = item2.Prostori.Find(x => x.Oznaka == oznakaProstora && x.Slobodan == true);
                    prostor.Prodaj(kupac);
                }
            }
            
        }
    }
}

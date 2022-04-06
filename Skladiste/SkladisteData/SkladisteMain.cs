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
            this.Artikli.Add(new UvozniArtikl("a", 5, 5));
        }

        public void DodajArtikl(IArtikl artikl)
        {
            Artikli.Add(artikl);
        }

        public List<IArtikl> DohvatiArtikle()
        {
            return this.Artikli;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_platforma_1
{
    internal class Film : VideoSadrzaj
    {
        public int Trajanje { get; set; }
        public Film(string naziv, string opis, int trajanje) : base(naziv, opis)
        {
            this.Vrsta = VrstaSadrzaja.Vrsta.Film;
            this.Trajanje = trajanje;
            Naziv = naziv;
            Opis = opis;
        }

       

        public override string VratiInfo()
        {
            return this.Naziv + this.Opis + this.Trajanje;
        }
    }
}

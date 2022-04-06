using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino2
{
    internal class Kino
    {
        public List<Dvorana> Dvorana { get; set; }
        public List<Projekcija> Projekcija { get; set; }

        public List<Projekcija> DohvatiProjekcije(string naziv)
        {
            return Projekcija.FindAll(x => x.PredstavaProjekcije.Naziv == naziv);
        }
    }
}

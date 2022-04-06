using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino1
{
    internal class Projekcija
    {
        public DateTime DatumProjekcija { get; set; }
        public Dvorana DvoranaProjekcija { get; set; }
        public Film FilmProjekcije { get; set; }
        public bool Premijera { get; set; }

    }
}

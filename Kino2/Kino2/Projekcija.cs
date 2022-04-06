using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino2
{
    internal class Projekcija
    {
        public DateTime DatumProjekcije { get; set; }
        public Dvorana DvoranaProjekcije { get;  set; }
        public IPredstava PredstavaProjekcije { get; set; } 
    }
}

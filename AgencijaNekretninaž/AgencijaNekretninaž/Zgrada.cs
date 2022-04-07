using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretninaž
{
    internal class Zgrada
    {
        public string OznakaZgrade { get; set; }
        public List<Kat> Katovi = new List<Kat>();
    }
}

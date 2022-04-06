using System.Collections.Generic;

namespace Streaming_platforma_1
{
    public class Sezona
    {
        public int RedniBroj { get; set; }
        public List<Epizoda> Epizode = new List<Epizoda>();
        public Sezona()
        {
        }
    }
}
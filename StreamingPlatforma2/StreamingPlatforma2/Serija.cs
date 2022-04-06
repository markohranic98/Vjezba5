using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatforma2
{
    internal class Serija : IVideoZapis
    {
        public int ID { get; set; }
        public string Naziv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Opis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public KategorijaZapisa Kategorija { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Sezona> Sezone { get; private set; }

        public Serija()
        {
            Random random = new Random();
            ID = random.Next();
        }
        public string Reproduciraj()
        {
            return "Započeta reprodukcija serija" + this.Naziv + "Sezone: " + Sezone[0].RedniBroj + "Epizoda: " + Sezone[0].listaEpizoda[0].Naziv;
        }
    }
}

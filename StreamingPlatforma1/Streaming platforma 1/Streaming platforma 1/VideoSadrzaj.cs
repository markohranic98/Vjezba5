using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming_platforma_1
{
    public abstract class VideoSadrzaj
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public VrstaSadrzaja.Vrsta Vrsta = new VrstaSadrzaja.Vrsta();

        public VideoSadrzaj(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
        }

        public abstract string VratiInfo();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatforma2
{
    public interface IVideoZapis
    {
        string Naziv { get; set; }
        string Opis { get; set; }
        KategorijaZapisa Kategorija { get; set; }
        string Reproduciraj();
    }
}

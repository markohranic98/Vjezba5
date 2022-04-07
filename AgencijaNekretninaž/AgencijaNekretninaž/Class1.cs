using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretninaž
{
    public interface IProstor
    {
        string Oznaka { get; set; }
        Kat KatProstora { get; set; }
        bool Slobodan { get; set; }
        int ID_Kata { get; set; }

        void Prodaj(string kupac);

    }
}

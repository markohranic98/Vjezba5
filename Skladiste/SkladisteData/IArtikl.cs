using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladisteData
{
    public interface IArtikl
    {
        string Ime { get; set; }
        int Cijena { get; set; }
        int Kolicina { get; set; }

        void DodajKolicinu();
        void MakniKolicinu();

    }
}

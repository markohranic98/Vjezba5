using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaci
{
    internal class GeneratorZadataka
    {
        public  List<Zadatak> Zadaci = new List<Zadatak>();

        public GeneratorZadataka()
        {
            
        }

        public void DodajZadatak(string naziv, DateTime datum)
        {
            Zadaci.Add(new Zadatak(naziv, datum));
            Zadaci.Sort((x,y)=>x.Rok.CompareTo(y.Rok));
        }

        public DateTime DohvatiVrijeme()
        {
            return DateTime.Now;
        }
        private bool Oboji(Zadatak zadatak)
        {
            if (zadatak.Rok < DateTime.Now)
            {
                return true;
            }
            return false;
        }

    }
}

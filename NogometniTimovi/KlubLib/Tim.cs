using System;
using System.Collections.Generic;

namespace KlubLib
{
    public class Tim
    {
        public List<Nogometas> NogometasiTima;
        public string NazivTima { get; set; }
        public int ID_Kluba { get; set; }
        public int ID { get; set; }
        public VrstaPostave.Postava Postava { get; set; }
        public Tim(int id, VrstaPostave.Postava postava,string naziv,int idtima)
        {
            ID_Kluba = id;
            NogometasiTima = new List<Nogometas>();
            Postava = postava;
            NazivTima = naziv;
            ID = idtima;

        }

        public void DodajIgracaTimu(Nogometas nogometas)
        {
            nogometas.ID_Tima = this.ID;
            this.NogometasiTima.Add(nogometas);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlubLib
{
    public class Klub
    {
        public string Naziv { get; set; }
        public List<Tim> Timovi { get; set; }
        public List<Nogometas> Nogometasi { get; set; }

        public int ID { get; set; }

        public Klub()
        {
            Random random = new Random();
            this.ID = random.Next();
            Timovi = new List<Tim>();
            Nogometasi = new List<Nogometas>();
            this.Timovi.Add(new Tim(this.ID,VrstaPostave.Postava._4_4_2,"Majmuni",1));
            this.Timovi.Add(new Tim(this.ID,VrstaPostave.Postava._3_5_2,"GOrile",4));
            this.Timovi.Add(new Tim(this.ID,VrstaPostave.Postava._4_4_2,"Cimpanze",2));
            this.Timovi.Add(new Tim(this.ID,VrstaPostave.Postava._4_3_3,"Orangutani",3));
            this.Nogometasi.Add(new Nogometas("Marko", "Kockica", this.ID, PozicijaEnum.Pozicija.Napadac));
            this.Nogometasi.Add(new Nogometas("Marko", "Musica", this.ID, PozicijaEnum.Pozicija.Napadac));
            this.Nogometasi.Add(new Nogometas("Marko", "Hranic", this.ID, PozicijaEnum.Pozicija.Napadac));
            this.Nogometasi.Add(new Nogometas("Marko", "Gabor", this.ID, PozicijaEnum.Pozicija.Napadac));
            this.Nogometasi.Add(new Nogometas("Karla", "Franović", this.ID, PozicijaEnum.Pozicija.Napadac));
            this.Nogometasi.Add(new Nogometas("Ivan", "Horvat", this.ID, PozicijaEnum.Pozicija.Branic));
            this.Nogometasi.Add(new Nogometas("Ivan", "Franić", this.ID, PozicijaEnum.Pozicija.Branic));
            this.Nogometasi.Add(new Nogometas("Ivan", "Franović", this.ID, PozicijaEnum.Pozicija.Branic));
            this.Nogometasi.Add(new Nogometas("Ivan", "Franković", this.ID, PozicijaEnum.Pozicija.Branic));
            this.Nogometasi.Add(new Nogometas("Ivan", "Franicevic", this.ID, PozicijaEnum.Pozicija.Branic));
            this.Nogometasi.Add(new Nogometas("Ivan", "Fran", this.ID, PozicijaEnum.Pozicija.Branic));
            this.Nogometasi.Add(new Nogometas("Ivan", "Ivan", this.ID, PozicijaEnum.Pozicija.Branic));
            this.Nogometasi.Add(new Nogometas("Petar", "Perić", this.ID, PozicijaEnum.Pozicija.Vezni));
            this.Nogometasi.Add(new Nogometas("Petar", "perović", this.ID, PozicijaEnum.Pozicija.Vezni));
            this.Nogometasi.Add(new Nogometas("Petar", "Petric", this.ID, PozicijaEnum.Pozicija.Vezni));
            this.Nogometasi.Add(new Nogometas("Petar", "Petar", this.ID, PozicijaEnum.Pozicija.Vezni));
            this.Nogometasi.Add(new Nogometas("Petar", "Pero", this.ID, PozicijaEnum.Pozicija.Vezni));
            this.Nogometasi.Add(new Nogometas("Petar", "Veznjak", this.ID, PozicijaEnum.Pozicija.Vezni));
            this.Nogometasi.Add(new Nogometas("Petar", "Testnipodatak", this.ID, PozicijaEnum.Pozicija.Vezni));
            this.Nogometasi.Add(new Nogometas("Ivica", "Testnipodatak", this.ID, PozicijaEnum.Pozicija.Golman));
            this.Nogometasi.Add(new Nogometas("Ivica", "Golman", this.ID, PozicijaEnum.Pozicija.Golman));
            this.Nogometasi.Add(new Nogometas("Ivica", "Golobranitelj", this.ID, PozicijaEnum.Pozicija.Golman));
        }
        
        public void DodajIgracaUKlub(string ime, string prezime, PozicijaEnum.Pozicija pozicija)
        {
            this.Nogometasi.Add(new Nogometas(ime,prezime,this.ID,pozicija));
        }

        public List<Tim> DohvatiTimove()
        {
            return Timovi;
        }

        public List<Nogometas> DostupniNogometasi()
        {
            return Nogometasi.FindAll(x=>x.ID_Tima==0);

        }

        public List<Nogometas> DohvatiNogometaseTima(Tim tim)
        {
            return tim.NogometasiTima;
        }

    }
}

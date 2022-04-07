using System.Collections.Generic;

namespace AgencijaNekretninaž
{
    public class Kat
    {
        public int BrojKata { get; set; }
        public int ID { get; set; }
        public List<IProstor> Prostori = new List<IProstor>();
    }
}
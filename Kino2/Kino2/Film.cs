using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino2
{
    internal class Film : IPredstava
    {
        public string Naziv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Trajanje { get; set; }
    }
}

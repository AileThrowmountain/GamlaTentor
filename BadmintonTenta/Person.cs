using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonTenta
{
    class Person
    {
        public string Förnamn { get; set; }
        public int Poäng { get; set; }
        public int[] SetPoäng { get; set; }
        public int AntalVunnaSet { get; set; }
        public bool Segrare { get; set; }

        public Person(string förnamn, int poäng, int[] setPoäng, int antalVunnaSet, bool segrare)
        {
            Förnamn = förnamn;
            Poäng = poäng;
            SetPoäng = setPoäng;
            AntalVunnaSet = antalVunnaSet;
            Segrare = segrare;
        }
        public Person()
        {

        }

    }
}

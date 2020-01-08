using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonTenta
{
    class Match
    {
        public int AktuelltSet { get; set; }

        public Person Spelare1 { get; set; }
        public Person Spelare2 { get; set; }

     
        public Match(Person spelare1, Person spelare2, int aktuelltSet)
        {
            Spelare1 = spelare1;
            Spelare2 = spelare2;
            AktuelltSet = aktuelltSet;

        }
        public Match()
        {

        }

        public void KollaSetSeger()
        {
           if (Spelare1.Poäng == 21)
            {   
                
                Spelare1.AntalVunnaSet++;

                int[] setSpelare1 = new int[AktuelltSet]; //lika många fack som vi har spelade set
                int[] setSpelare2 = new int[AktuelltSet];

                Spelare1.SetPoäng = setSpelare1;
                Spelare2.SetPoäng = setSpelare2;

                Spelare1.SetPoäng[AktuelltSet - 1] = Spelare1.Poäng;
                Spelare2.SetPoäng[AktuelltSet - 1] = Spelare2.Poäng;

                Spelare1.Poäng = 0;
                Spelare2.Poäng = 0;

                AktuelltSet++;

            }
           else if (Spelare2.Poäng == 21)
            {
                
                Spelare2.AntalVunnaSet++;

                int[] setSpelare1 = new int[AktuelltSet];
                int[] setSpelare2 = new int[AktuelltSet];

                Spelare1.SetPoäng = setSpelare1;
                Spelare2.SetPoäng = setSpelare2;

                Spelare1.SetPoäng[AktuelltSet - 1] = Spelare1.Poäng;
                Spelare2.SetPoäng[AktuelltSet - 1] = Spelare2.Poäng;

                Spelare2.Poäng = 0;
                Spelare1.Poäng = 0;

                AktuelltSet++;
            }
            
        }
        public void GePoäng(Person person, Person person2)
        {
            person.Poäng++;
            KollaSetSeger();



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggtenta
{
    class Hen
    {
        public string Breed { get; set; }
        public double Weight { get; set; }

        private static readonly Random random = new Random();


        public int LayEgg()
        {
            if (random.Next(100) + 1 <= 48)//Om slumpen (1-100) är 48 eller mindre, skicka tillbaka 1 (la ägg), annars 0 (la inget ägg)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return random.Next(100) + 1 <= 48 ? 1 : 0; //annat exempel
        }
        public Egg LayEgg2() //konstruktor metod
        {
            if (random.Next(100) + 1 <= 48)
            {
                return new Egg(random.Next(20, 81));
            }
            else
            {
                return null;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggtenta
{
    class HenHouse
    {
        public string Stable { get; set; }
        public List<Hen> Hens { get; set; } = new List<Hen>();

        public HenHouse(int numberOfHens)
        {
            for (int i = 0; i < 50; i++)
            {
                Hens.Add(new Hen());
            }
        }
        public int CountEggs()
        {
            int sum = 0; //en variabel för att samla summan av äggen
            foreach (Hen hen in Hens) //För varje höna i listan, är summan += höna och eventuellt lagt ägg. (min metod LayEgg returnerar om det är ett ägg eller inte)
            {
                sum += hen.LayEgg();
            }
            return sum;
        }

    }
}

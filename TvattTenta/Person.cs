using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvattTenta
{
    class Person
    {
        public List<Clothes> CollectionFriday { get; set; } = new List<Clothes>();
        public List<Clothes> CollectionSaturday { get; set; } = new List<Clothes>();
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
          



        }

        public void NewWardrobe()
        {
            Clothes Jeans = new Clothes();
            Clothes Tshirt = new Clothes();
            Clothes Kavaj = new Clothes();
            Clothes Skjorta = new Clothes();
            Clothes Slips = new Clothes();

            Jeans.Type = "Jeans";
            Tshirt.Type = "T-shirt";
            Kavaj.Type = "Kavaj";
            Skjorta.Type = "Skjorta";
            Slips.Type = "Slips";

            Jeans.Color = "Blå";
            Tshirt.Color = "Vit";
            Kavaj.Color = "Svart";
            Skjorta.Color = "Rosa";
            Slips.Color = "Lila";


            CollectionFriday.Add(Jeans);
            CollectionFriday.Add(Tshirt);
            CollectionSaturday.Add(Kavaj);
            CollectionSaturday.Add(Skjorta);
            CollectionSaturday.Add(Slips);

        }

     
    }
}

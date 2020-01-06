using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matvarutenta
{
    class Product
    {

        public string Type { get; set; }

        public int NumberOf { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }

        public Product(string type, int numberOf, double price)
        {
            Type = type;

            NumberOf = numberOf;
  
            Price = price;



        }


        public override string ToString()
        {
            return ($"{Type} {Price:C}");
        }
    }
}

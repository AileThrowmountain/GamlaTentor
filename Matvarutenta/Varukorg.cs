using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matvarutenta
{
   
    class Varukorg
    {

        public double Total { get; set; } 

        public List<Product> varulista = new List<Product>();

        public Varukorg()
        {

        }
  
        public Varukorg(double total)
        {
            Total = total;
        }

        public void AddProduct(Product product)
        {
            varulista.Add(product);
        }
   

        public double GetTotalSum()
        {
            double total = 0;
            foreach (Product product in varulista)
            {
                total += product.Price * product.NumberOf;
            }
            return total;
        }
    }
}

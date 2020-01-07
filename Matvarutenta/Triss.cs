using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matvarutenta
{
    class Triss
    {
        Random random = new Random();


        public bool IsTriss()
        {
            int lott = random.Next(0, 101);
            
            if (lott <=33)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}

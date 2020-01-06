using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvattTenta
{
    class Clothes
    {
        public string Charecteristics { get; set; }
        public string Type { get; set; }
        public int WashTemperature { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return ($"{Type} {Color}");
        }
    }
}

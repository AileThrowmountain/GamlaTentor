using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skidtenta
{
    class Tävlande
    {
        public int[] Bonussekunder { get; set; } = new int[5];
        public string Land { get; set; }
        public string Namn { get; set; }

        //public override string ToString()
        //{
        //    return ($" {Namn} {Land} ");
        //}
    }

}

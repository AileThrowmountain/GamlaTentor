using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValUppgift3
{
    public class Party
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public double Percentage { get; set; }
        public int NumberOfVotes { get; set; }

        public Party()
        {

        }
        public Party(string name, string abbrevation)
        {
            Name = name;
            Abbreviation = abbrevation;
        }
    }
}

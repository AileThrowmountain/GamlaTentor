using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaSparetTenta
{
    class Question
    {
        public Question(int number)
        {
            Number = number;
        }

        public bool Correct { get; set; }
        public bool IsTaken { get; set; }
        public int Number { get; set; }
        public int Points { get; set; }


    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valet
{
    public class VoteCounter
    {

        public string VoteCount(int counterNo, int counterYes, int counterNoOppinion)
        {
            string voteA = "A";
            string voteB = "B";
            string voteC = "C";

            if (counterNo > counterYes && counterNo > counterNoOppinion)
            {
                return ($"Alternativ {voteA} fick flest röster.");
            }
            else if (counterYes > counterNo && counterYes > counterNoOppinion)
            {
                return ($"Alternativ {voteB} fick flest röster.");
            }
            else if (counterNoOppinion > counterNo && counterNoOppinion > counterYes)
            {
                return ($"Alternativ {voteC} fick flest röster.");
            }
            else
            {
                return ($"Det går inte att avgöra vinnande alternativ");
            }
        }


    }
}

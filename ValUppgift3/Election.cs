using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValUppgift3
{
    public class Election
    {
        public List<Party> Parties { get; set; } = new List<Party>();

        public void AddParty(Party party)
        {
            Parties.Add(party);
        }
    }
}

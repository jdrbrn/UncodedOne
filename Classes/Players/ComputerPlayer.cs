using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(Party party) : base(party) { }

        protected override int PickAction(Battle battle, Character character)
        {
            //Only supports running the first action (DoNothing)
            return 0;
        }
    }
}
